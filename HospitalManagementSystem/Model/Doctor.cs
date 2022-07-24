using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Model
{
    public class Doctor:Staff
    {
        public string Specialization { get; set; } = string.Empty;

        public string Experience { get; set; } = string.Empty;
        public int Fees { get; set; }
        public int PatientChecked { get; set; }

        public int NumberOfOperation { get; set; }


        /// <summary>
        /// Creating dictionary with Doctor
        /// </summary>
        public Dictionary<int, Doctor> DictionaryDoctor;
        public Doctor()
        {
            DictionaryDoctor = new Dictionary<int, Doctor>();
        }

        public void RegisterNewStaff(int Staffid, Doctor doctor)
        {
            DictionaryDoctor.Add(Staffid, doctor);

        }
    }
}
