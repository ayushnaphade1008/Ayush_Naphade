// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to string");
Console.WriteLine("Enter the string");
string  string_name = "The James Bond series focuses on a fictional British Secret Service agent \n"+
 "created in 1953 by writer Ian Fleming, who featured him in twelve novels"+
"and two short-story collections. Since Fleming's death in 1964, eight other"+
 "authors have written authorised Bond novels or novelisations: Kingsley Amis,"+
"Christopher Wood, John Gardner, Raymond Benson, Sebastian Faulks, Jeffery Deaver,"+
 "William Boyd, and Anthony Horowitz. The latest novel is Forever and a Day by Anthony Horowitz,"+
 "published in May 2018. Additionally Charlie Higson wrote a series on a young "+
 "James Bond, and Kate Westbrook wrote three novels based on the diaries of a "+
"recurring series character, Moneypenny."+
"The character—also known by the code number 007 (pronounced \"double-O-seven \")"+
" has also been adapted for television, radio, comic strip, video games and film."+
" The films are one of the longest continually running film series and have grossed"+
 "over US$7.04 billion in total, making it the fifth-highest-grossing film series to date,"+
 "which started in 1962 with Dr. No, starring Sean Connery as Bond. As of 2021, there have"+
" been twenty-five films in the Eon Productions series. The most recent Bond film, No Time" +
" to Die (2021), stars Daniel Craig in his fifth portrayal of Bond; he is the sixth actor"+
" to play Bond in the Eon series. There have also been two independent productions of"+
"Bond films: Casino Royale(a 1967 spoof starring David Niven) and Never Say Never Again "+
 "(a 1983 remake of an earlier Eon-produced film, 1965's Thunderball, both starring Connery)."+ 
"In 2015, the series was estimated to be worth $19.9 billion,[1] making James Bond one of the"+
"highest-grossing media franchises of all time.";


int count_statement = 0;
int count_word;
int count_space = 0;


for (int i1 = 0; i1 < string_name.Length; i1++)
{
   
    if (string_name[i1].Equals('.'))
    {
        count_statement ++;
    }
   /* string[] str_split_1 = string_name.Split(' ');
    for (int i = 0; i < str_split_1.Length; i++)
    {
        if (str_split_1[i].Contains("Dr.") || str_split_1[i].Contains(".edu") )
        {
            count_statement--;
        }
    }*/
}
Console.WriteLine($"The number of statements are {count_statement}");


for (int i2 = 0; i2 < string_name.Length; i2++)
{
    
    if (string_name[i2].Equals(' '))
    {
        count_space += 1;
    }
}
Console.WriteLine($"The number of spaces are {count_space}");


string[] str_split = string_name.Split(' ');
count_word = str_split.Length;
Console.WriteLine();
Console.WriteLine($"The number of wordcounts are {count_word}");
Console.WriteLine();



foreach (string str in str_split)
{
    string upd_string = char.ToUpper(str[0]) + str.Substring(1);
   // string final_string = string.Join(" ", upd_string);
    Console.Write(upd_string + " ");
}
Console.WriteLine();
Console.WriteLine();

for (int i2 = 0; i2 < string_name.Length; i2++)
{
    char j = string_name[i2];
    if(j == '0' || j == '1' || j == '2' || j == '3' || j == '4' || j == '5' || j == '6' || j == '7' || j == '8' || j == '9')
    {
        Console.WriteLine($"index of {j} is {i2}"); ;
        
    }
}

string CharTOCeck = "@!#$%&/\\|()=?»«@£§€{}\".-;'<>_,";
foreach (char ch in CharTOCeck)
{
    if (string_name.Contains(ch))
    {
        Console.WriteLine($"Special character is {ch}");
    }
}






