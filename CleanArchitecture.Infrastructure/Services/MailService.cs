using CleanArchitecture.Application.Services;
using CleanArchitecture.Infrastructure.Options;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;

namespace CleanArchitecture.Infrastructure.Services;

public sealed class MailService : IMailService
{
    private readonly MailSettings _mailSettings;

    public MailService(IOptions<MailSettings> mailOptions)
    {
        _mailSettings = mailOptions.Value;
    }

    public async Task SendAsync(string recipientEmail, string subject, string body, bool isHtml = true, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(recipientEmail);
        ArgumentException.ThrowIfNullOrWhiteSpace(subject);
        ArgumentException.ThrowIfNullOrWhiteSpace(body);

        var message = new MimeMessage();

        message.From.Add(new MailboxAddress(
                _mailSettings.SenderName,
                _mailSettings.SenderEmail
                ));

        message.To.Add(MailboxAddress.Parse(recipientEmail));
        message.Subject = subject;

        var bodyBuilder = new BodyBuilder();

        if (isHtml)
            bodyBuilder.HtmlBody = body;
        else
            bodyBuilder.TextBody = body;

        message.Body = bodyBuilder.ToMessageBody();

        using var smtpClient = new SmtpClient();

        try
        {
            var socketOptions = _mailSettings.UseSsl ? SecureSocketOptions.SslOnConnect : SecureSocketOptions.StartTls;

            await smtpClient.ConnectAsync(_mailSettings.Host, _mailSettings.Port, socketOptions, cancellationToken);

            if (!string.IsNullOrWhiteSpace(_mailSettings.UserName))
            {
                await smtpClient.AuthenticateAsync(_mailSettings.UserName, _mailSettings.Password, cancellationToken);
            }

            await smtpClient.SendAsync(message, cancellationToken);
        }
        finally
        {
            if (smtpClient.IsConnected)
            {
                await smtpClient.DisconnectAsync(quit: true, cancellationToken);
            }
        }
    }
}