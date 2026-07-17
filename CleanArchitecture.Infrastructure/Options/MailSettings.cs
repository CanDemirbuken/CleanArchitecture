namespace CleanArchitecture.Infrastructure.Options;

public sealed class MailSettings
{
    public const string SectionName = "MailSettings";

    public string Host { get; set; } = default!;
    public int Port { get; set; }
    public string SenderEmail { get; set; } = default!;
    public string SenderName { get; set; } = default!;
    public string UserName { get; set; } = default!;
    public string Password { get; set; } = default!;
    public bool UseSsl { get; set; }
}