//using NetTemplate.API.Constants;
//using NetTemplate.BLL.Services.Interfaces;
//using NetTemplate.DAL.Data.MetaDatas;
//using NetTemplate.DAL.Data.Requests.Otp;
//using NetTemplate.DAL.Data.Responses.Otp;
//using Microsoft.AspNetCore.Mvc;

//namespace NetTemplate.API.Controllers
//{
//    [ApiController]
//    public class OtpController : BaseController<OtpController>
//    {
//        private readonly IOtpService _otpService;

//        public OtpController(ILogger<OtpController> logger, IOtpService otpService) : base(logger)
//        {
//            _otpService = otpService;
//        }

//        [HttpPost(ApiEndPointConstant.Otp.ValidateOtp)]
//        [ProducesResponseType(typeof(ValidateOtpResponse), StatusCodes.Status200OK)]
//        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status400BadRequest)]
//        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status500InternalServerError)]
//        public async Task<IActionResult> ValidateOtp([FromBody] ValidateOtpRequest request)
//        {
//            if (!ModelState.IsValid)
//            {
//                return BadRequest(ApiResponseBuilder.BuildErrorResponse<object>(
//                    null,
//                    StatusCodes.Status400BadRequest,
//                    "Invalid request",
//                    "The request data is invalid"
//                ));
//            }

//            var response = await _otpService.ValidateOtp(request.Email, request.Otp);

//            if (response.Success)
//            {
//                return Ok(ApiResponseBuilder.BuildResponse(
//                    StatusCodes.Status200OK,
//                    "OTP validated successfully",
//                    response
//                ));
//            }
//            else
//            {
//                return BadRequest(ApiResponseBuilder.BuildErrorResponse<object>(
//                    null,
//                    StatusCodes.Status400BadRequest,
//                    "OTP validation failed",
//                    response.Message
//                ));
//            }
//        }
//    }
//}
