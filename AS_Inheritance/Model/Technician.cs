using AS_Inheritance.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS_Inheritance.Model
{
    public class Technician:Staff
    {
     public int NumberOfOperationHandle { get; set; }
     public int NumberOfEquipRepaired { get; set; }
    }

}
