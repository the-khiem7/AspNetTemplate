using NetTemplate.DAL.Data.Requests.Auth;
using NetTemplate.DAL.Data.Responses.Auth;

namespace NetTemplate.BLL.Services.Interfaces
{
    public interface IAuthService
    {
        Task<LoginResponse> Login(LoginRequest loginRequest);
        Task<ForgotPasswordResponse> ForgotPassword(ForgotPasswordRequest forgotPasswordRequest);
        Task<ChangePasswordResponse> ChangePassword(ChangePasswordRequest changePasswordRequest);
    }
}
