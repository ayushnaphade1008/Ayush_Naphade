using AS_Inheritance.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS_Inheritance.Model


{
    public class Nurse: Staff
    {
        public int NumberOfInjection { get; set; }  
        public int NummberOfPatientAssign { get; set; }
    } 
}
