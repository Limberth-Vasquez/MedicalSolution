using AppLogic;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentManager _appointmentManager;

        public AppointmentController(IAppointmentManager appManager)
        {
            _appointmentManager = appManager;
        }

        [HttpPost("CrearCita")]
        public string CreateAppointment(Appointment dto) 
        {
            return _appointmentManager.CreateAppointment(dto);
        }
    }
}
