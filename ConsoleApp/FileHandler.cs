namespace ConsoleApp
{
    internal class FileHandler
    {
        public bool CreateFile()
        {
            bool success = true;

            try
            {
                // Ingen multi \ separator hvis cross platform
                // C:\Users\UserName

                string myUserFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

                // Brug path.Combine i stedet for separator
                File.Create(Path.Combine(myUserFolder, "Niels.txt"));
            }
            catch (Exception)
            {
                success = false;
            }

            return success;
        }
    }
}
