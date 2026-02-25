using DTO;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [EnableCors("DemoPolicy")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        [HttpGet]
        public ApiResponse GetDoctor()
        {
            var response = new ApiResponse();
            try
            {
                response.Data = "Datos del doctor";
                response.Result = "ok";
            }
            catch (Exception ex)
            {
                response.Result = "error";
                response.Message = ex.Message;
            }
            return response;
        }
        [HttpGet]
        public ApiResponse GetAllDoctors()
        {
            var response = new ApiResponse();
            try
            {
                response.Data = "Datos de todos los doctores";
                response.Result = "ok";
            }
            catch (Exception ex)
            {
                response.Result = "error";
                response.Message = ex.Message;
            }
            return response;
        }
        [HttpGet("GetByDoctor")]
        public ApiResponse GetDoctorById(int pIdDoctor)
        {
            var response = new ApiResponse();
            try
            {
                response.Data = "Datos del doctor by doctor ";
                response.Result = "ok";
            }
            catch (Exception ex)
            {
                response.Result = "error";
                response.Message = ex.Message;
            }
            return response;
        }
    }
}
