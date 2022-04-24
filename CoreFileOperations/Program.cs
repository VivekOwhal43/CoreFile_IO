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
            fileOp.DeleteFile();                    // Calling method

            // Stream opeartions
            StreamOperationsRW streamOperationsRW = new StreamOperationsRW();
            streamOperationsRW.ReadFromStreamReader();
            streamOperationsRW.WriteUsingStreamWriter();
        }
    }
}