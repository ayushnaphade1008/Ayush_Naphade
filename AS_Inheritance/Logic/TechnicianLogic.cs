using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS_Inheritance.Logic
{
    public class TechnicianLogic
    {

        Dictionary<string, Model.Technician> DictionaryTechnician;
        public TechnicianLogic()
        {
            DictionaryTechnician = new Dictionary<string, Model.Technician>();

        }
    }
}