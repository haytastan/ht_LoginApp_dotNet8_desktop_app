using Microsoft.AspNetCore.Identity.UI.Services;

namespace LoginApp.Services;

public class EmailSender : IEmailSender
{
    private readonly ILogger<EmailSender> _logger;
    private readonly IConfiguration _configuration;

    public EmailSender(ILogger<EmailSender> logger, IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }

    public Task SendEmailAsync(string email, string subject, string htmlMessage)
    {
        // In a real application, you would implement email sending logic here
        // This could use SendGrid, SMTP, etc.
        
        _logger.LogInformation("Email: {Email}, Subject: {Subject}, Message: {Message}", 
            email, subject, htmlMessage);
        
        // For development, just log the email
        return Task.CompletedTask;
    }
}