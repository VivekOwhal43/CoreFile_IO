namespace CoreFileOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("File Operations using DotNetCore");      
            FileOp fileOp = new FileOp();           // Creating object of FileOp class
            fileOp.FileExists();                    // Calling method FileExists()
            fileOp.ReadAllLines();                  // Calling method ReadAllLines()
            fileOp.CopyFile();                      // Calling method CopyFile()
        }
    }
}