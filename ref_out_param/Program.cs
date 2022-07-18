// See https://aka.ms/new-console-template for more information

int i = 0;
int total = 0;
int product = 0;
Calcy(5, 10, out total, out product);
Console.WriteLine($"Sum={total} and Product={product}");
DemoRef(ref i);
Console.WriteLine(i);

static void DemoRef(ref int j)
{
    j = 2;
}
static void Calcy(int fnum, int snum, out int sum,out int product)
{
    sum = fnum + snum;
    product = fnum * snum;
}