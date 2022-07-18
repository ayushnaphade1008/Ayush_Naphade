// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string[] arr5 = { "Mayank", "Mohit", "Ravi", "Ramesh", "Mayank", "Mohit", "Raju", "Mohit", "Mayank", "Alex", "Eliza", "Alex" };
Console.WriteLine("Original Array ");
foreach (string s in arr5)
    Console.Write(s + " ");
Console.WriteLine("\n");
Array.Sort(arr5);
int val_1 = 0;
for (int i = 0; i < arr5.Length-1;)
{
    int count = 0;
    while ( arr5[val_1] == arr5[i])
    {
        count++;
        i++;
      
    }
    Console.WriteLine($"String {arr5[val_1]}  frequency is : {count}");
    val_1 = i; ;
}
Console.WriteLine("\n");
