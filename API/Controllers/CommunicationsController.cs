using AppLogic;
using DTO;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [EnableCors("DemoPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class CommunicationsController : ControllerBase
    {
        private readonly IEmailManager _emailManager;

        public CommunicationsController(IEmailManager emailManager)
        {
            _emailManager = emailManager;
        }

        [HttpGet("EnviarCorreo")]
        public ApiResponse SendEmail(string emailAddress)
        {
            var response = new ApiResponse();
            try
            {
                response.Result = "ok";
                response.Data = _emailManager.SendEmail(emailAddress);
            }
            catch (Exception e)
            {
                response.Result = "error";
                response.Message = e.Message + " " + e.InnerException?.Message;
            }

            return response;
        }
    }
}
