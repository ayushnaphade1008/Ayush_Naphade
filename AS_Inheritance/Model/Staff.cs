using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS_Inheritance.Model
{
    public class Staff
    {
        public int StaffId { get; set; }
        public string StaffName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string ContactNo { get; set; } = string.Empty;
        public string? Education { get; set; }
        public int ShiftStartTime { get; set; }
        public int ShiftEndTime { get; set; }
        public int BasicPay { get; set; }
        public string DeptName { get; set; } = string.Empty;

        public string Gender { get; set; } = string.Empty;
        public string DateOfBirth { get; set; } = string.Empty;

        public int StaffType { get; set; }

        public void RegisterNewStaff(int Staffid, Object stafftype)
        {
            DictionaryStaff.Add(Staffid, stafftype);
          
        }

       public Dictionary<int, object> DictionaryStaff;
        public Staff()
        {
            DictionaryStaff = new Dictionary<int,object>();
        }
    }
}
