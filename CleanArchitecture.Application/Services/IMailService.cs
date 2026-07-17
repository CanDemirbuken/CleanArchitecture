namespace CleanArchitecture.Application.Services;

public interface IMailService
{
    Task SendAsync(string recipientEmail, string subject, string body, bool isHtml = true, CancellationToken cancellationToken = default);
}