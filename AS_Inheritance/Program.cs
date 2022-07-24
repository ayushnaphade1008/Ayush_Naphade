// See https://aka.ms/new-console-template for more information
using AS_Inheritance.Logic;
using AS_Inheritance.Model;

Console.WriteLine("HOSPITAL MANAGEMENT SYSTEM USING DICTIONARY TO COLLECT INFORMATION");
Doctor doctor = new Doctor();
Nurse nurse = new Nurse();
Staff staff = new Staff();
Technician technician = new Technician();
DoctorLogic drlogic = new DoctorLogic();
NurseLogic nslogic = new NurseLogic();
TechnicianLogic techlogic = new TechnicianLogic();
bool choice = true;

do
{
    Console.ReadLine();
    Console.WriteLine("Insert the Operation you want to Perform");
    Console.WriteLine("1.Add New Registration in Record");
    Console.WriteLine("2.Update Data in Record");
    Console.WriteLine("3.Delete Data in Record");
    Console.WriteLine("4.Get Data By Id");
    Console.WriteLine("5.GetIncomeofEachStaffByStaffID");
    Console.WriteLine("6.ListOfDoctorBasedonSpecialization");

    int operation = Convert.ToInt32(Console.ReadLine());

   
    switch (operation)
    {
        case 1:
           
            }
            var staffs1 = drlogic.RegisterNewStaff(Staffid, doctor);
            foreach (var kvp in staffs1)
            {
                Console.WriteLine($" StaffId={Staffid} \n StaffName={doctor.StaffName} \n Email={doctor.Email} \n Contact Number={doctor.ContactNo} \n Education={doctor.Education} \n ShiftTimeStart={doctor.ShiftStartTime} \n ShiftTimeEnd={doctor.ShiftEndTime} \n Basic Pay={doctor.BasicPay} \n Department={doctor.DeptName} \n Gender={doctor.Gender} \n DateOfBirth={doctor.DateOfBirth} \n Specialization={doctor.Education} \n Experience={doctor.Fees} \n Patient Checked={doctor.PatientChecked} \n Operation Performed={doctor.NumberOfOperation}");

            }
            /*  case 2:
                  Console.WriteLine("Registration process Begins for Nurse");

                  Console.WriteLine("Enter Staff ID");
                  nurse.StaffId = Convert.ToInt32(Console.ReadLine());

                  Console.WriteLine("Enter Staff Person Name");
                  nurse.StaffName = Console.ReadLine();

                  Console.WriteLine("Enter Email");
                  nurse.Email = Console.ReadLine();

                  Console.WriteLine("Enter Mobile Number");
                  nurse.ContactNo = Console.ReadLine();

                  Console.WriteLine("Enter Education ");
                  nurse.Education = Console.ReadLine();

                  Console.WriteLine("Enter Shift Start Time");
                  nurse.ShiftStartTime = Convert.ToInt32(Console.ReadLine());

                  Console.WriteLine("Enter Shift End Time");
                  nurse.ShiftEndTime = Convert.ToInt32(Console.ReadLine());

                  Console.WriteLine("Enter BasicPay");
                  nurse.BasicPay = Convert.ToInt32(Console.ReadLine());

                  Console.WriteLine("Enter Department");
                  nurse.DeptName = Console.ReadLine();

                  Console.WriteLine("Enter Gender");
                  nurse.Gender = Console.ReadLine();

                  Console.WriteLine("Enter DOB");
                  nurse.DateOfBirth = Console.ReadLine();

                  Console.WriteLine("Enter Number of Injection Enjected");
                  nurse.NumberOfInjection = Convert.ToInt32(Console.ReadLine());

                  Console.WriteLine("Enter Number of Patient Assigned");
                  nurse.NummberOfPatientAssign = Convert.ToInt32(Console.ReadLine());

                  break;
              case 3:
                  Console.WriteLine("Registration process Begins for Technician");

                  Console.WriteLine("Enter Staff ID");
                  technician.StaffId = Convert.ToInt32(Console.ReadLine());

                  Console.WriteLine("Enter Staff Person Name");
                  technician.StaffName = Console.ReadLine();

                  Console.WriteLine("Enter Email");
                  technician.Email = Console.ReadLine();

                  Console.WriteLine("Enter Mobile Number");
                  technician.ContactNo = Console.ReadLine();

                  Console.WriteLine("Enter Education ");
                  technician.Education = Console.ReadLine();

                  Console.WriteLine("Enter Shift Start Time");
                  technician.ShiftStartTime = Convert.ToInt32(Console.ReadLine());

                  Console.WriteLine("Enter Shift End Time");
                  technician.ShiftEndTime = Convert.ToInt32(Console.ReadLine());

                  Console.WriteLine("Enter BasicPay");
                  technician.BasicPay = Convert.ToInt32(Console.ReadLine());

                  Console.WriteLine("Enter Department");
                  technician.DeptName = Console.ReadLine();

                  Console.WriteLine("Enter Gender");
                  technician.Gender = Console.ReadLine();

                  Console.WriteLine("Enter DOB");
                  technician.DateOfBirth = Console.ReadLine();

                  Console.WriteLine("Enter Number of Equipment Repaired");
                  technician.NumberOfEquipRepaired = Convert.ToInt32(Console.ReadLine());

                  Console.WriteLine("Enter Number Operation Handle");
                   technician.NumberOfOperationHandle = Convert.ToInt32(Console.ReadLine());
                  break;
              default:
                  Console.WriteLine("Enter Proper Operation");
                  break;
          }
          //var staffs1 = logic.RegisterNewStaff(staff);


          //foreach (var s in staffs1)
          {
       //       Console.WriteLine($"StaffID:{s.StaffId}  StaffName:{s.StaffName}  Email:{s.Email}  DeptName:{s.DeptName}  Gender:{s.Gender}  DOB:{s.DateOfBirth}  StaffCategry:{s.StaffCategory}  Staff Education:{s.Education}  ContactNo:{s.ContatNo}");
          }

          break;
      case 2:
          Console.WriteLine("******Updatation process start******");
          Console.WriteLine("1.Updatation for Doctor");
          Console.WriteLine("2.Updatation for Nurse");
          Console.WriteLine("3.Updatation for Technician");
          int OperationForUpdadation = Convert.ToInt32(Console.ReadLine());

          switch (OperationForUpdadation)
          {
              case 1:
                  Console.WriteLine("Updatation process Begins for Doctor");

                  Console.WriteLine("Enter Staff ID");
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

                  break;
              case 2:
                  Console.WriteLine("Updatation process Begins for Nurse");

                  Console.WriteLine("Enter Staff ID");
                  nurse.StaffId = Convert.ToInt32(Console.ReadLine());

                  Console.WriteLine("Enter Staff Person Name");
                  nurse.StaffName = Console.ReadLine();

                  Console.WriteLine("Enter Email");
                  nurse.Email = Console.ReadLine();

                  Console.WriteLine("Enter Mobile Number");
                  nurse.ContactNo = Console.ReadLine();

                  Console.WriteLine("Enter Education ");
                  nurse.Education = Console.ReadLine();

                  Console.WriteLine("Enter Shift Start Time");
                  nurse.ShiftStartTime = Convert.ToInt32(Console.ReadLine());

                  Console.WriteLine("Enter Shift End Time");
                  nurse.ShiftEndTime = Convert.ToInt32(Console.ReadLine());

                  Console.WriteLine("Enter BasicPay");
                  nurse.BasicPay = Convert.ToInt32(Console.ReadLine());

                  Console.WriteLine("Enter Department");
                  nurse.DeptName = Console.ReadLine();

                  Console.WriteLine("Enter Gender");
                  nurse.Gender = Console.ReadLine();

                  Console.WriteLine("Enter DOB");
                  nurse.DateOfBirth = Console.ReadLine();

                  Console.WriteLine("Enter Number of Injection Enjected");
                  nurse.NumberOfInjection = Convert.ToInt32(Console.ReadLine());

                  Console.WriteLine("Enter Number of Patient Assigned");
                  nurse.NummberOfPatientAssign = Convert.ToInt32(Console.ReadLine());
                  break;
              case 3:
                  Console.WriteLine("Updatation process Begins for Technician");

                  Console.WriteLine("Enter Staff ID");
                  technician.StaffId = Convert.ToInt32(Console.ReadLine());

                  Console.WriteLine("Enter Staff Person Name");
                  technician.StaffName = Console.ReadLine();

                  Console.WriteLine("Enter Email");
                  technician.Email = Console.ReadLine();

                  Console.WriteLine("Enter Mobile Number");
                  technician.ContactNo = Console.ReadLine();

                  Console.WriteLine("Enter Education ");
                  technician.Education = Console.ReadLine();

                  Console.WriteLine("Enter Shift Start Time");
                  technician.ShiftStartTime = Convert.ToInt32(Console.ReadLine());

                  Console.WriteLine("Enter Shift End Time");
                  technician.ShiftEndTime = Convert.ToInt32(Console.ReadLine());

                  Console.WriteLine("Enter BasicPay");
                  technician.BasicPay = Convert.ToInt32(Console.ReadLine());

                  Console.WriteLine("Enter Department");
                  technician.DeptName = Console.ReadLine();

                  Console.WriteLine("Enter Gender");
                  technician.Gender = Console.ReadLine();

                  Console.WriteLine("Enter DOB");
                  technician.DateOfBirth = Console.ReadLine();

                  Console.WriteLine("Enter Number of Equipment Repaired");
                  technician.NumberOfEquipRepaired = Convert.ToInt32(Console.ReadLine());

                  Console.WriteLine("Enter Number Operation Handle");
                  technician.NumberOfOperationHandle = Convert.ToInt32(Console.ReadLine());
                  break;
          }
        /*  var staffs2 = logic.UpdateStaffInfo(id_updated, staff);
          foreach (var s in staffs2)
          {
              Console.WriteLine($"StaffID:{s.StaffId}  StaffName:{s.StaffName}  Email:{s.Email}  DeptName:{s.DeptName}  Gender:{s.Gender}  DOB:{s.DateOfBirth}  StaffCategry:{s.StaffCategory}  Staff Education:{s.Education}  ContactNo:{s.ContatNo}");
          }
        */

            break;
    case 3:
            Console.WriteLine("******Deletion process start******");
            Console.WriteLine("1.Deletion for Doctor");
            Console.WriteLine("2.Deletion for Nurse");
            Console.WriteLine("3.Deletion for Technician");
            int OperationForRemove = Convert.ToInt32(Console.ReadLine());

            switch (OperationForRemove)
            {
                case 1:
                    Console.WriteLine("Enter Staff ID of Doctor which you want to delete");
                    int StaffIdDoctorRemoved = Convert.ToInt32(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("Enter Staff ID of Nurse which you want to delete");
                    int StaffIdNurseRemoved = Convert.ToInt32(Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine("Enter Staff ID of Doctor which you want to delete");
                    int StaffIdTechnicianRemoved = Convert.ToInt32(Console.ReadLine());
                    break;
            }
            /*   Console.WriteLine("Removin Data in records ");
               //staff = new Staff();
               Console.WriteLine("Enter Staff ID");
               int id_removed = Convert.ToInt32(Console.ReadLine());
               var staffs3 = logic.DeleteStaff(id_removed);
               foreach (var s in staffs3)
               {
                   Console.WriteLine($"StaffID:{s.StaffId}  StaffName:{s.StaffName}  Email:{s.Email}  DeptName:{s.DeptName}  Gender:{s.Gender}  DOB:{s.DateOfBirth}  StaffCategry:{s.StaffCategory}  Staff Education:{s.Education}  ContactNo:{s.ContatNo}");
               } */
            break;
    case 4:
        /* var staffs = logic.GetAllStaff();
        foreach (var s in staffs)
        {
            Console.WriteLine($"StaffID:{s.StaffId}  StaffName:{s.StaffName}  Email:{s.Email}  DeptName:{s.DeptName}  Gender:{s.Gender}  DOB:{s.DateOfBirth}  StaffCategry:{s.StaffCategory}  Staff Education:{s.Education}  ContactNo:{s.ContatNo}");
        } */

        break;
    case 5:
        //staff = logic.GetStaffIncomeById(1);


        break;
    case 6:
        break;
   

        default:
            break;

    }

} while (choice == true); 