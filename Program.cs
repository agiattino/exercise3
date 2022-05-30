using System;
using System.IO;


namespace Exercise3MyDocuments // Note: actual namespace depends on the project name.
{
    class Exercise3MyDocuments
    {
        


        static void Main(string[] args) 
        {
            string directoryString = @"C:\Users\username\Documents";

            string archiveDirectory = @"C:\archive";

            string myPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            try
            {
                var txtFiles = Directory.EnumerateFiles(directoryString, "*.*");    

                foreach (string currentFile in txtFiles)
                {
                    string fileName = currentFile.Substring(myPath.Length + 1);

                    //Directory.Move(currentFile, Path.Combine(archiveDirectory, fileName));

                    Directory.GetFiles(currentFile, Path.Combine(myPath, fileName));

					Console.WriteLine($"This is the path INCULDED my files:  {myPath}. {fileName}");
                    Console.WriteLine($"This is the path to my files:  {myPath}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}