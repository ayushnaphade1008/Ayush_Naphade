// See https://aka.ms/new-console-template for more information
using System.Collections;
/* Console.WriteLine("Collections Stack And LinkedList");
Stack stack = new Stack();
stack.Push("Ayush");
stack.Push("Naphade");
stack.Push("Nitin");
foreach (string item in stack)
{
    Console.WriteLine(item);
}
Console.WriteLine($"Peek element {stack.Peek()}");
Console.WriteLine($"Pop element {stack.Pop()}");
Console.WriteLine($"after Peek/pop element {stack.Peek()}");

Stack stc = new Stack();
Console.WriteLine("Enter Size");
int n =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter elements");
for (int i = 1; i <= n; i++)
{
    stc.Push(Console.ReadLine());
}

for (int i = 0; i < stc.Count; i++)
{
    Console.WriteLine($"items in stack are {stc.Pop()}");
}
*/
List<int> li = new List<int>();
li.Add(1); li.Add(2); li.Add(3);
foreach(object obj in li)
{
    Console.Write(" " + obj);
}

Console.ReadLine();