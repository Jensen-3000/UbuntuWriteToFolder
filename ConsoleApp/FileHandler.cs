namespace ConsoleApp
{
    internal class FileHandler
    {
        public string FileName { get; set; }
        public string MyUserDir
        {
            get => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
        }

        public FileHandler(string fileName) => FileName = fileName;

        public FileHandler()
        {
        }

        public void CreateFile() => File.Create(Path.Combine(MyUserDir,FileName));

        //public bool CreateFile()
        //{
        //    bool success = true;

        //    try
        //    {
        //        // Ingen multi \ separator hvis cross platform
        //        // C:\Users\UserName

        //        string myUserFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

        //        // Brug path.Combine i stedet for separator
        //        File.Create(Path.Combine(myUserFolder, "Niels.txt"));
        //    }
        //    catch (Exception)
        //    {
        //        success = false;
        //    }

        //    return success;
        //}

    }
}
