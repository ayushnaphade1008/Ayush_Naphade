using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS_Inheritance.Logic
{
    public class NurseLogic
    {
        Dictionary<int,Model.Nurse>  DictionaryNurse;
        public NurseLogic()
        {
            DictionaryNurse = new Dictionary<int, Model.Nurse>();
        }
    }
}
