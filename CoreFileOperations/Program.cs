namespace CoreFileOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("File Operations using DotNetCore");
            FileOp fileOp = new FileOp();
            fileOp.FileExists();
            fileOp.ReadAllLines();
        }
    }
}