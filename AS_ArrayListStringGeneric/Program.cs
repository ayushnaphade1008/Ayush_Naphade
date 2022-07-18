
using System.Collections;
using System.Collections.Generic;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("*********-----Assignment JULY 15-----*********");
String[] str_1 = new string[]{"Ayush","Kiran","Aditya", "Kiran" ,"Kiran","Hrit","om","om","Rushikesh", "Hrit","Omkareshwar","MansiPaturkar","MansiPatil","AyushNaphade"};
int[] int_1 = new int[] { 22, 45, 91, 54, 23, 10, 71, 1, 12, 0, 22, 91, 1, 91, 54, 54, 54 };

List<string> list_str = new List<string>();
list_str.Add("Ayush");
list_str.Add("Hritik");
list_str.Add("Ayan");
list_str.Add("Ayush");
list_str.Add("Om");
list_str.Add("Hru");
list_str.Add("Omkareshwar");
list_str.Add("Anushka");
list_str.Add("Rushikesh");
list_str.Add("Rishikeshwar");
list_str.Add("Hru");
list_str.Add("Muskan");
list_str.Add("Omkarkulkarni");
list_str.Add("Aditysambare");
list_str.Add("Muskan");
list_str.Add("Ayush");
string NumofTime = "Repeat";

List<int> list_array = new List<int>();
list_array.Add(22);
list_array.Add(45);
list_array.Add(91);
list_array.Add(54);
list_array.Add(10);
list_array.Add(18);
list_array.Add(11);
list_array.Add(27);
list_array.Add(29);
list_array.Add(88);
list_array.Add(68);
list_array.Add(71);
list_array.Add(81);
list_array.Add(22);
list_array.Add(18);


String temp = String.Empty;
do
{
    Console.WriteLine();
    Console.WriteLine("1.Sort String Array bases on index"+ "\n"
        + "2.Reverse String Array bases on index" + "\n"
        +"3.Print Index Of Even Number" + "\n"+ 
        "4.Print Index of Odd Number" + "\n" +
        "5.Print Inde of Prime Number" + "\n"+ "6.Strings that contains 'a' in it at any position in that string" +
        "\n" + "7.Strings that contains A,M,K,a,m,k in it at any position in that string" +"\n"+
        "8.repeated strings in an array and print them" +"\n" +
        "9.repeated element in an array and print them" +"\n"+
        "10.Sort String Array bases on index (using Generic)" + "\n"
        + "11.Reverse String Array bases on index (using Generic)" + "\n"
        + "12.Print Index Of Even Number (using Generic)" + "\n" +
        "13.Print Index of Odd Number (using Generic)" + "\n" +
        "14.Print Inde of Prime Number (using Generic)" + "\n" + "15.Strings that contains 'a' in it at any position in that string (using Generic)" +
        "\n" + "16.Strings that contains A,M,K,a,m,k in it at any position in that string (using Generic)" + "\n" +
        "17.repeated strings in an array and print them (using Generic)" + "\n" +
        "18.repeated element in an array and print them (using Generic)");
    
    int choice = Convert.ToInt32(Console.ReadLine());
    
    switch (choice)
    {
        case 1:
            for (int ind = 0; ind < str_1.Length-1; ind++)
            {
                for (int j = ind + 1; j < str_1.Length; j++)
                {

                    if (str_1[ind].Length > str_1[j].Length)
                    {
                        temp = str_1[ind];
                        str_1[ind] = str_1[j];
                        str_1[j] = temp;

                    }
                }                         
            }
            foreach (var item in str_1)
            {
                Console.WriteLine(item);
            }

            break;
        case 2:
            for (int ind = 0; ind < str_1.Length - 1; ind++)
            {
                for (int j = ind + 1; j < str_1.Length; j++)
                {

                    if (str_1[ind].Length > str_1[j].Length)
                    {
                        temp = str_1[ind];
                        str_1[ind] = str_1[j];
                        str_1[j] = temp;

                    }
                }

            }
            foreach (var item in str_1)
            {
                Console.WriteLine(item);
            }
            Array.Reverse(str_1);
            Console.WriteLine();
            Console.WriteLine("Array after Reverse");
            foreach (var item in str_1)
            {
                Console.WriteLine(item);
            }

            break;
        case 3:
            Console.WriteLine("Indexes of Even Number");
            for (int ind = 0; ind < int_1.Length ; ind++)
            {
                int result = int_1[ind] % 2;
                
                if (result == 0 && int_1[ind]!=0)
                {
                    
                  
                    Console.WriteLine($"Index of {int_1[ind]} is {ind}");
                    
                }
                
            }
    
            break;
        case 4:
            Console.WriteLine("Indexes of Odd Number");
            for (int ind = 0; ind < int_1.Length ; ind++)
            {
                int result = int_1[ind] % 2;
                
                if (result == 1 && int_1[ind] != 0)
                {
                                   
                    Console.WriteLine($"Index of {int_1[ind]} is {ind}");
                }
               
            }
            break;
        case 5:
            Console.WriteLine("Index of Prime Numbers");
            for(int ind = 0; ind < int_1.Length; ind++)
            {
                int Flag = 0;
                for (int i = 2; i <= int_1[ind] / 2; i++)
                {
                    if (int_1[ind] % i == 0 && int_1[ind] != 0)
                    {
                        Flag = 1;
                        break;
                    }
                    
                }
                if (Flag== 0 && int_1[ind] != 0)
                {
                    
                    Console.WriteLine($"Index of {int_1[ind]} is {ind}");
                }                   
            }
           
            break;
        case 6:
            Console.WriteLine("Strings that contains 'a' in it at any position in that string");
            foreach(string str in str_1)
            {
                if (str.Contains('a') || str.Contains('A'))
                {
                    Console.WriteLine(str);
                }
            }
           
            break;
        case 7:
            Console.WriteLine("Strings that starts A,M,K,a,m,k in it at any position in that string");
            foreach (string str in str_1)
            {
                if (str.StartsWith('A') || str.StartsWith('M') || str.StartsWith('K') || str.StartsWith('a') || str.StartsWith('m') || str.StartsWith('k'))
                {
                    Console.WriteLine(str);
                }
            }
            break;
        case 8:
            Console.WriteLine("repeated strings in an array and print them");
            Array.Sort(str_1);
            int temp_1 = 0;
                      
            for (int ind = 0; ind < str_1.Length-1;)
            {
                int count = 0;
              
                    while(str_1[temp_1]== str_1[ind])
                    {                   
                    count++;
                    ind++;
                    }
             Console.WriteLine($"SubString {str_1[temp_1]} appears {count} times in array");
             temp_1 = ind;
            }
            

            break;
        case 9:
            Console.WriteLine("repeated integer elements in an array and print them");

            Array.Sort(int_1);
            int temp_2 = 0;

            for (int ind = 0; ind < str_1.Length - 1;)
            {
                int count = 0;

                while (int_1[temp_2] == int_1[ind])
                {
                    count++;
                    ind++;
                }
                Console.WriteLine($"SubString {int_1[temp_2]} appears {count} times in array");
                temp_2 = ind;
            }
            break;
        case 10:
            for (int ind = 0; ind < list_str.Count - 1; ind++)
            {
                for (int j = ind + 1; j < list_str.Count; j++)
                {

                    if (list_str[ind].Length > list_str[j].Length)
                    {
                        temp = list_str[ind];
                        list_str[ind] = list_str[j];
                        list_str[j] = temp;

                    }
                }
            }
            foreach (var item in list_str)
            {
                Console.WriteLine(item);
            }
          break;
        case 11:
            for (int ind = 0; ind < list_str.Count - 1; ind++)
            {
                for (int j = ind + 1; j < list_str.Count; j++)
                {

                    if (list_str[ind].Length > list_str[j].Length)
                    {
                        temp = list_str[ind];
                        list_str[ind] = list_str[j];
                        list_str[j] = temp;

                    }
                }
            }
            foreach (var item in list_str)
            {
                Console.WriteLine(item);
            }
            list_str.Reverse();
            Console.WriteLine();
            Console.WriteLine("Array after Reverse");
            foreach (var item in list_str)
            {
                Console.WriteLine(item);
            }
            break;
        case 12:
            Console.WriteLine("EVEN");
            for (int ind = 0; ind < list_array.Count; ind++)
            {
                if (list_array[ind] % 2 == 0 && list_array[ind]!=0) {
                    Console.WriteLine($"Index of {list_array[ind]} is {ind}");
                } 
            }
            break;
        case 13:
            Console.WriteLine("ODd");
            for (int ind = 0; ind < list_array.Count; ind++)
            {
                if (list_array[ind] % 2 != 0 && list_array[ind] != 0)
                {
                    Console.WriteLine($"Index of {list_array[ind]} is {ind}");
                }
            }
            break;
        case 14:
            Console.WriteLine("Index of Prime Numbers");
            for (int ind = 0; ind < list_array.Count; ind++)
            {
                int Flag = 0;
                for (int i = 2; i <= list_array[ind] / 2; i++)
                {
                    if (list_array[ind] % i == 0 && list_array[ind] != 0)
                    {
                        Flag = 1;
                        break;
                    }

                }
                if (Flag == 0 && int_1[ind] != 0)
                {

                    Console.WriteLine($"Index of {list_array[ind]} is {ind}");
                }
            }
            break;
        case 15:
            Console.WriteLine("Strings that contains 'a' in it at any position in that string");
            foreach (string str in list_str)
            {
                if (str.Contains('a') || str.Contains('A'))
                {
                    Console.WriteLine(str);
                }
            }


            break;
        case 16:
            Console.WriteLine("Strings that starts with  A,M,K,a,m,k ");
            foreach (string str in list_str)
            {
                if (str.StartsWith('A') || str.StartsWith('M') || str.StartsWith('K') || str.StartsWith('a') || str.StartsWith('m') || str.StartsWith('k'))
                {
                    Console.WriteLine(str);
                }
            }
            break;
        case 17:
            Console.WriteLine("repeated substring elements in an array and print them");
            list_str.Sort();
            int temp_3 = 0;

            for (int ind = 0; ind < list_str.Count - 1;)
            {
                int count = 0;

                while (list_str[temp_3] == list_str[ind])
                {
                    count++;
                    ind++;
                }
                Console.WriteLine($"SubString {list_str[temp_3]} appears {count} times in array");
                temp_3 = ind;
            }
            break;
        case 18:
            Console.WriteLine("repeated integer elements in an array and print them");
            list_array.Sort();
            int temp_4 = 0;

            for (int ind = 0; ind < list_array.Count - 1;)
            {
                int count = 0;

                while (list_array[temp_4] == list_array[ind])
                {
                    count++;
                    ind++;
                }
                Console.WriteLine($"SubString {list_array[temp_4]} appears {count} times in array");
                temp_4 = ind;
                
            }
            break;



        default:
            Console.WriteLine("Select proper Operation");
            break;
    }
}
while (NumofTime=="Repeat");

/*Print String Array
static void PrintstringArray(String[] StrArray)
{
    foreach (string str in StrArray)
    {
        Console.Write(str + " ");
    }
}
static void PrintArray(int[] Array)
{
    for(int i = 0; i < Array.Length; i++)
    {
        Console.Write(Array[i] + " ");
    }
}
*/
