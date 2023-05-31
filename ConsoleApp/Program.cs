using ConsoleApp;
using System.Security.Cryptography.X509Certificates;


// ToDo bruger input for filename
// ${fileName}.txt

Console.WriteLine("1. Opret fil");
Console.WriteLine("2. Vis bruger folder URL");

string input = Console.ReadLine();
int inputValue;
bool success = int.TryParse(input, out inputValue);

while (!success)
{
    Console.WriteLine("Invalid Input. Prøv igen...");
    Console.Write("Indtast et tal: ");
    input = Console.ReadLine();
    success = int.TryParse(input, out inputValue);
}

if (inputValue == 1)
{
    OpretFil();
}

if (inputValue == 2)
{
    FileHandler fileHandler = new FileHandler();
    Console.WriteLine(fileHandler.MyUserDir);
}
if (inputValue == 3)
{
    CountSeconds();
}

void OpretFil()
{
    FileHandler fileHandler = new FileHandler("Niklas.txt");

    try
    {
        fileHandler.CreateFile();
        Console.WriteLine("Success");
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

void CountSeconds()
{
    int y = 1;
    while (true)
    {
        Console.Clear();
        Console.WriteLine(y);
        Thread.Sleep(1000);
        y++;
    }
}