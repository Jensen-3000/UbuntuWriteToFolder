﻿namespace ConsoleApp
{
    internal class WriteToFile
    {
        public void WriteToFileInUserDocuments()
        {

            // Create a string array with the lines of text
            string[] lines = { "First line", "Second line", "Third line" };

            // Set a variable to the Documents path.
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Write the string array to a new file named "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "WriteLines.txt")))
            {
                foreach (string line in lines)
                    outputFile.WriteLine(line);
            }
        }
    }
}
