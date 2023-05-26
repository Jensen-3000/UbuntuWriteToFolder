using ConsoleApp;

WriteToFile write = new WriteToFile();
try
{
    write.WriteToFileInUserDocuments();
}
catch (Exception ex)
{
    Console.WriteLine("Couldnt write to file." + ex);
}