// See https://aka.ms/new-console-template for more information
using CS_Basic_Class;

Console.WriteLine("Welcome to Hospital Management System");

Staff staff = new Staff();//obj of staff class

StaffLogic logic = new StaffLogic();//obj of logic class
bool choice =true;
do
{
    Console.ReadLine();
    Console.WriteLine("Insert the Operation you want to Perform");
    Console.WriteLine("1.Add New Registration in Record");
    Console.WriteLine("2.Update Data in Record");
    Console.WriteLine("3.Delete Data in Record");
    Console.WriteLine("4.Get Data By Id");
    Console.WriteLine("5.Getallstaff");

    int operation = Convert.ToInt32(Console.ReadLine());
    

   

    switch (operation)
    {
        case 1:
            Console.WriteLine("******Registration process start******");
          //  Staff staf = new Staff();
            Console.WriteLine("Enter Staff ID");
            staff.StaffId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Staff Person Name");
            staff.StaffName = Console.ReadLine();
            Console.WriteLine("Enter Email");
            staff.Email = Console.ReadLine();
            Console.WriteLine("Enter Department Name");
            staff.DeptName = Console.ReadLine();
            Console.WriteLine("Enter Gender");
            staff.Gender = Console.ReadLine();
            Console.WriteLine("Enter DOB");
            staff.DateOfBirth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Staf Category");
            staff.StaffCategory = Console.ReadLine();
            Console.WriteLine("Enter Education ");
            staff.Education = Console.ReadLine();
            Console.WriteLine("Enter Mobile Number");
            staff.ContatNo = Console.ReadLine();

            var staffs1 = logic.RegisterNewStaff(staff);


            foreach (var s in staffs1)
            {
                Console.WriteLine($"StaffID:{s.StaffId}  StaffName:{s.StaffName}  Email:{s.Email}  DeptName:{s.DeptName}  Gender:{s.Gender}  DOB:{s.DateOfBirth}  StaffCategry:{s.StaffCategory}  Staff Education:{s.Education}  ContactNo:{s.ContatNo}");
            }

            break;
        case 2:

            Console.WriteLine("Updating Data in records ");
            Console.WriteLine("Enter Staff ID");
            int id_updated = Convert.ToInt32(Console.ReadLine());
            //staff = new Staff();
            Console.WriteLine("Enter Staff ID");
            staff.StaffId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Staff Person Name");
            staff.StaffName = Console.ReadLine();
            Console.WriteLine("Enter Email");
            staff.Email = Console.ReadLine();
            Console.WriteLine("Enter Department Name");
            staff.DeptName = Console.ReadLine();
            Console.WriteLine("Enter Gender");
            staff.Gender = Console.ReadLine();
            Console.WriteLine("Enter DOB");
            staff.DateOfBirth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Staf Category");
            staff.StaffCategory = Console.ReadLine();
            Console.WriteLine("Enter Education ");
            staff.Education = Console.ReadLine();
            Console.WriteLine("Enter Mobile Number");
            staff.ContatNo = Console.ReadLine();

            var staffs2 = logic.UpdateStaffInfo(id_updated, staff);
            foreach (var s in staffs2)
            {
                Console.WriteLine($"StaffID:{s.StaffId}  StaffName:{s.StaffName}  Email:{s.Email}  DeptName:{s.DeptName}  Gender:{s.Gender}  DOB:{s.DateOfBirth}  StaffCategry:{s.StaffCategory}  Staff Education:{s.Education}  ContactNo:{s.ContatNo}");
            }


            break;
        case 3:
            Console.WriteLine("Removin Data in records ");
            //staff = new Staff();
            Console.WriteLine("Enter Staff ID");
            int id_removed = Convert.ToInt32(Console.ReadLine());
            var staffs3 = logic.DeleteStaff(id_removed);
            foreach (var s in staffs3)
            {
                Console.WriteLine($"StaffID:{s.StaffId}  StaffName:{s.StaffName}  Email:{s.Email}  DeptName:{s.DeptName}  Gender:{s.Gender}  DOB:{s.DateOfBirth}  StaffCategry:{s.StaffCategory}  Staff Education:{s.Education}  ContactNo:{s.ContatNo}");
            }
            break;
        case 4:

            staff = logic.GetStaffById(1);
            break;
        case 5:
            var staffs = logic.GetAllStaff();
            foreach (var s in staffs)
            {
                Console.WriteLine($"StaffID:{s.StaffId}  StaffName:{s.StaffName}  Email:{s.Email}  DeptName:{s.DeptName}  Gender:{s.Gender}  DOB:{s.DateOfBirth}  StaffCategry:{s.StaffCategory}  Staff Education:{s.Education}  ContactNo:{s.ContatNo}");
            }

            break;
        default:
            break;

    }
   
} while (choice==true);
