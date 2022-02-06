// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Choose task: ");
Console.WriteLine("1. Convert to base64");
Console.WriteLine("2. Convert base64 to string");
Console.Write("Your selection: ");
var task = Console.ReadLine();

if (task == "1")
{
    Console.Write("Enter string to convert to base64: ");
    var stringToParse = Console.ReadLine();
    if (stringToParse == null)
    {
        Console.WriteLine("No content found. Exiting");
    }
    else
    {
        Console.WriteLine("---------------------");
        Console.Write("Output: ");
        Console.WriteLine(Convert.ToBase64String(Encoding.UTF8.GetBytes(stringToParse)));
    }
}
else if (task == "2")
{
    Console.WriteLine("Enter base64 string to decode");
    var stringToDecode = Console.ReadLine();
    if (stringToDecode == null)
    {
        Console.WriteLine("No content found. Exiting");
    }
    else
    {
        Console.WriteLine("---------------------");
        Console.WriteLine("Output:");
        Console.WriteLine(Convert.FromBase64String(stringToDecode));
    }
}
else
{
    Console.WriteLine("Selection not supported. Aborting ...");
}
