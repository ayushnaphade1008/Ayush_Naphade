// See https://aka.ms/new-console-template for more information
using CS_Basic_Class;

Console.WriteLine("Welcome to Hospital Management System");

Staff staff = new Staff();

StaffLogic logic = new StaffLogic();

var staffs = logic.GetAllStaff();

foreach (var s in staffs)
{
    Console.WriteLine($"{s.StaffId} {s.StaffName}");
}


staff = logic.GetStaffById(1);
Console.WriteLine($"{staff.StaffId} {staff.StaffName} {staff.DeptName}");

string condition = "Repeat";
do
{
    Console.ReadLine();
    Console.WriteLine("Insert the Operation you want to Perform");
    Console.WriteLine("1.Add New Registration in Record");
    Console.WriteLine("2.Update Data in Record");
    Console.WriteLine("3.Delete Data in Record");
    Console.WriteLine("4.Get Data By Id");

    int operation = Convert.ToInt32(Console.ReadLine());

    switch (operation)
    {
        case 1:
            Console.WriteLine("******Registration process start******");
            staff = new Staff();
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

            staffs = logic.RegisterNewStaff(staff);

            foreach (var s in staffs)
            {
                Console.WriteLine($"StaffID:{s.StaffId}  StaffName:{s.StaffName}  Email:{s.Email}  DeptName:{s.DeptName}  Gender:{s.Gender}  DOB:{s.DateOfBirth}  StaffCategry:{s.StaffCategory}  Staff Education:{s.Education}  ContactNo:{s.ContatNo}");
            }

            break;
        case 2:
            Console.WriteLine("Updating Data in records ");
            //staff = new Staff();
            Console.WriteLine("Enter Staff ID");
            int id_updated = Convert.ToInt32(Console.ReadLine());
            staffs = logic.UpdateStaffInfo(id_updated, staff);


            break;
        case 3:
            Console.WriteLine("Removin Data in records ");
            //staff = new Staff();
            Console.WriteLine("Enter Staff ID");
            int id_removed = Convert.ToInt32(Console.ReadLine());
            staffs = logic.DeleteStaff(id_removed);
            foreach (var s in staffs)
            {
                Console.WriteLine($"StaffID:{s.StaffId}  StaffName:{s.StaffName}  Email:{s.Email}  DeptName:{s.DeptName}  Gender:{s.Gender}  DOB:{s.DateOfBirth}  StaffCategry:{s.StaffCategory}  Staff Education:{s.Education}  ContactNo:{s.ContatNo}");
            }
            break;
        case 4:
            break;
        default:
            break;

    }
} while (condition == "Repeat");
