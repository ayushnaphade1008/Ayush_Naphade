using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS_Inheritance.Logic
{
    public class DoctorLogic
    {
        Model.Doctor doctor = new Model.Doctor();
        Model.Staff staff = new Model.Staff();
        public void RegisterDoctor()
        {
            Console.WriteLine("******Registration process start******");
            doctor.StaffType = 1;
            Console.WriteLine("Enter Staff Id");
            doctor.StaffId = Convert.ToInt32(Console.ReadLine());
            
   

            Console.WriteLine("Enter Staff Person Name");
            doctor.StaffName = Console.ReadLine();

            Console.WriteLine("Enter Email");
            doctor.Email = Console.ReadLine();

            Console.WriteLine("Enter Mobile Number");
            doctor.ContactNo = Console.ReadLine();

            Console.WriteLine("Enter Education ");
            doctor.Education = Console.ReadLine();

            Console.WriteLine("Enter Shift Start Time");
            doctor.ShiftStartTime = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Shift End Time");
            doctor.ShiftEndTime = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter BasicPay");
            doctor.BasicPay = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Department");
            doctor.DeptName = Console.ReadLine();

            Console.WriteLine("Enter Gender");
            doctor.Gender = Console.ReadLine();

            Console.WriteLine("Enter DOB");
            doctor.DateOfBirth = Console.ReadLine();

            Console.WriteLine("Enter Specialization");
            doctor.Specialization = Console.ReadLine();

            Console.WriteLine("Enter Experience");
            doctor.Experience = Console.ReadLine();

            Console.WriteLine("Enter Doctor Fees");
            doctor.Fees = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number of Patient Checked");
            doctor.PatientChecked = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number of Operation Performed");
            doctor.NumberOfOperation = Convert.ToInt32(Console.ReadLine());

            staff.RegisterNewStaff(1,doctor);
        }

        public Model.Staff ShowDoctor(int staffid)
        {
            Model.Staff staffdoctor =new Model.Staff();
            foreach (var kvp in staff.DictionaryStaff)
            {
                if (kvp.Key == staffid)
                {
                    staffdoctor = staff.DictionaryStaff[kvp];
                    break;
                }
            }
            return staffdoctor;
            
        }
        
    }
}