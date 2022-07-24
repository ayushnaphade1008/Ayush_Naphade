// See https://aka.ms/new-console-template for more information
decimal fnum, snum, addn, subn, muln, divn, SquareOfFirstNum;
long BaseValue, ExpoValue;

string repeat = "Repeat"; 
do
{
    Console.WriteLine("Enter Operation you want to perform");
    Console.WriteLine("1.Addition");
    Console.WriteLine("2.substraction");
    Console.WriteLine("3.Multiplication");
    Console.WriteLine("4.Division");
    Console.WriteLine("5.Square");
    Console.WriteLine("6.Power");
    Console.WriteLine("7.SquareRoot");
    Console.WriteLine();
    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.WriteLine("Enter the first number");
            fnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            snum = Convert.ToInt32(Console.ReadLine());
            addn = fnum + snum;
            Console.WriteLine($"Addition is {addn}");
            Console.WriteLine();
            break;
        case 2:
            Console.WriteLine("Enter the first number");
            fnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            snum = Convert.ToInt32(Console.ReadLine());
            subn = fnum - snum;
            Console.WriteLine($"substraction is {subn}");
            Console.WriteLine();
            break;
        case 3:
            Console.WriteLine("Enter the first number");
            fnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            snum = Convert.ToInt32(Console.ReadLine());
            muln = fnum * snum;
            Console.WriteLine($"Multiplication is {muln}");
            Console.WriteLine();
            break;
        case 4:
            Console.WriteLine("Enter the first number");
            fnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            snum = Convert.ToInt32(Console.ReadLine());
            if (snum == 0)
            {
                Console.WriteLine("Cant divided by zero");
            }
            else
            {
                divn = fnum / snum;
                Console.WriteLine($"division is {divn}");
                Console.WriteLine();
            }
            break;
        case 5:
            Console.WriteLine("Enter the first number");
            fnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            snum = Convert.ToInt32(Console.ReadLine());
            SquareOfFirstNum = fnum * fnum;
            Console.WriteLine($"Square of {fnum} is {SquareOfFirstNum}");
            Console.WriteLine();
            break;
        case 6:
            Console.WriteLine("Enter the first number");
            BaseValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            ExpoValue = Convert.ToInt32(Console.ReadLine());
            int flag = 1;
            long pow = 1;

            //for power with simple method
            while (flag <= ExpoValue)
            {
                pow = pow * BaseValue;
                flag++;
            }
            Console.WriteLine($"Power is {pow}");
            Console.WriteLine();
          
            break;
        case 7:
            Console.WriteLine("enter Value");
            int value = Convert.ToInt32(Console.ReadLine());
            int integer = 1;

            //for square root wiht floor value
            while (integer * integer <= value)
            {
                integer++;
            }
            Console.WriteLine($"Square root of {value} is {integer - 1}");
            Console.WriteLine();

            break;
        default:
            break;

    }
    
    
} while (repeat == "Repeat");

