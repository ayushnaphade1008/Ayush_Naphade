using System.Collections;
using System.Collections.Generic;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hashset");
HashSet<string> names = new HashSet<string>();
names.Add("Shubhamm");
names.Add("Ankit");
names.Add("Abhishek");
names.Add("Vaibhav");
names.Add("Aniket");//no dublicate values

Dictionary<string, string> dist = new Dictionary<string, string>();
dist.Add("1", "Shubh");
dist.Add("2", "Ani");
dist.Add("3", "Abhi");
dist.Add("4", "Vaibhz");
dist.Add("5", "Bhaskar");


foreach (var name in names)
{
    Console.Write(name + " ");
}
Console.WriteLine();

foreach (KeyValuePair<string, string> kv in dist)
{
    Console.WriteLine(kv.Key + " " + kv.Value);
}
Console.WriteLine("enter key");
if (dist.ContainsKey(str)){
    Console.WriteLine($"value of {str} is {dist[str]}");
}
else{
    Console.WriteLine("String not found related to key");
}