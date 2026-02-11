using DTO;

namespace AppLogic
{
    public interface IPatientManager
    {
        List<Patient> GetAllPatient();
        string GetPatientByDoctor(int pIdDoctor);
        string GetPatient();
    }
    public class PatientManager : IPatientManager
    {
        public List<Patient> GetAllPatient()
        {
            var patients = new List<Patient>();
            patients.Add(new Patient() { Name = "Erick" });
            patients.Add(new Patient() { Name = "Bryan" });
            patients.Add(new Patient() { Name = "David" });

            return patients;
        }
        public string GetPatientByDoctor(int pIdDoctor)
        {
            return "Datos del paciente by doctor " + pIdDoctor;
        }
        public string GetPatient()
        {
            return "Datos del paciente";
        }
    }
}
