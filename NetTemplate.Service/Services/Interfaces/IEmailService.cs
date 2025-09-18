using NetTemplate.DAL.Data.Requests.Email;
using NetTemplate.DAL.Data.Responses.Email;

namespace NetTemplate.BLL.Services.Interfaces
{
    public interface IEmailService
    {
        Task SendClaimApprovedEmail(Guid Id);
        Task SendClaimReturnedEmail(Guid Id);
        Task SendClaimSubmittedEmail(Guid Id);
        Task SendManagerApprovedEmail(Guid Id);
        Task SendEmailAsync(string recipientEmail, string subject, string body);
        Task<SendOtpEmailResponse> SendOtpEmailAsync(SendOtpEmailRequest request);

    }
}
