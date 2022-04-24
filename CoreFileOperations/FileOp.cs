namespace CoreFileOperations
{
    public class FileOp
    {
        string path = @"/home/vivek/bridgelabz/CoreFile_IO/CoreFileOperations/MyFile.txt";
        public void FileExists()                // method for checking if file is present or not
        {
            if (File.Exists(path))              // if file is present then its path and message will be printed
            {
                Console.WriteLine($"File is present in {path} directory. \n");
            }
            else                              // if file is not present then following msg will be displayed
            {
                Console.WriteLine("File does not exist. \n");
            }
        }
        public void ReadAllLines()              // method for reading contents present in a file.
        {
            string lines;
            if (File.Exists(path))                  // check if file is present or not
            {
                Console.WriteLine("\nReading Content of file");     // if file is present then content will be printed on console
                lines = File.ReadAllText(path);
                Console.WriteLine(lines);
            }
            else                                                    // if file is not present then this block will be executed.
            {
                Console.WriteLine("File does not exist.");
            }
        }
        
        public void CopyFile()                  //method for copying a file
        {
            if(File.Exists(path))                           // if file is present then it will be copied in the specified directory
            {
                Console.WriteLine("========== COPY FILE ===========");
                string copyPath=@"/home/vivek/bridgelabz/CoreFile_IO/Copy-MyFile.txt";
                File.Copy(path,copyPath);
                Console.WriteLine($"File has been copied in :\n {copyPath}");
            }
            else                                        // if some problem occures then this block will be executed.
            {
                Console.WriteLine("File Does Not Exist \n========= or ==========\n Error Occured During Copy Operation");
            }
        }
        public void DeleteFile()                  //method for deleting a file
        {
            if(File.Exists(path))                           // if file is present then it will be deleted from the specified directory
            {
                Console.WriteLine("========== DELETE FILE =========");
                string copyPath=@"/home/vivek/bridgelabz/CoreFile_IO/Copy-MyFile.txt";
                File.Delete(copyPath);
                Console.WriteLine($"File has been successfully deleted from below path :\n {copyPath}");
            }
            else                                        // if some problem occures then this block will be executed.
            {
                Console.WriteLine("File Does Not Exist \n========= or ==========\n Error Occured During delete Operation");
            }
        }
    }
}