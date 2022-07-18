// See https://aka.ms/new-console-template for more information
int fnum, snum, addn, subn, muln, divn;
int flag = 1;
int pow = 1;

Console.WriteLine("Enter the first number");
fnum= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number");
snum = Convert.ToInt32(Console.ReadLine());
addn = fnum + snum;
subn = fnum - snum;
muln = fnum * snum;
divn = fnum / snum;
while (flag <= snum)
{
    pow = pow * fnum;
    flag++;
}
Console.WriteLine($"Power is {pow}");
Console.WriteLine($"Addition is {addn}");
Console.WriteLine($"substraction is {subn}");
Console.WriteLine($"Multiplication is {muln}");
Console.WriteLine($"division is {divn}");
Console.WriteLine($"Square of first number is {fnum * fnum} and square of second number is {snum * snum}");
/*
double Power = power(fnum, snum);
Console.WriteLine($"Power of recursive function is {Power}");

static double power(int fnum,int snum)
{

    for (int i = 1; i<=snum; i++)
    {
        fnum= (int)((fnum) * power(fnum,snum));
    }
    return fnum;
}

*/



