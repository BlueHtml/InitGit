using System.Runtime.InteropServices;

Console.WriteLine("1");

try
{
    Console.WriteLine("2");

    Console.WriteLine(RuntimeInformation.OSDescription);

    Console.WriteLine("3");
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}

Console.WriteLine("4");
