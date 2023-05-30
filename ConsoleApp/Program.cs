using ConsoleApp;

FileHandler fileHandler = new FileHandler("Niklas.txt");

try
{
    fileHandler.CreateFile();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}