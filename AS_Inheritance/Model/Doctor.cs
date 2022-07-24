using AS_Inheritance.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS_Inheritance.Model
{
    public class Doctor:Staff
    {
        public string Specialization{ get; set; } =string.Empty;

        public string Experience{ get; set; }  = string.Empty;
        public int Fees { get; set; }
        public int PatientChecked { get; set; }

        public int NumberOfOperation { get; set; }


       
    }
}
