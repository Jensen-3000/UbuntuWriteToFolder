using ConsoleApp;

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