using DataAccess.Crud;
using DTO;

namespace AppLogic
{
    public interface IAppointmentManager 
    {
        string CreateAppointment(Appointment appointment);
    }
    public class AppointmentManager : IAppointmentManager
    {
        public string CreateAppointment(Appointment appointment)
        {
            var appointmentCrud = new AppointmentCrud();
            appointmentCrud.Create(appointment);
            return "Cita registrada de manera correcta";
        }
    }
}
