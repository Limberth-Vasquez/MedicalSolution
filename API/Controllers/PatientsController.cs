using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        [HttpGet("Get")]
        public string GetPatient()
        {
            return "Datos del paciente";
        }
        [HttpGet("GetAll")]
        public List<Patient> GetAllPatient()
        {
            var patients = new List<Patient>();
            patients.Add(new Patient() { Name = "Erick" });
            patients.Add(new Patient() { Name = "Bryan" });
            patients.Add(new Patient() { Name = "David" });

            return patients;
        }
        [HttpGet("GetByDoctor")]
        public string GetPatientByDoctor(int pIdDoctor)
        {
            return "Datos del paciente by doctor " + pIdDoctor;
        }
    }
}
