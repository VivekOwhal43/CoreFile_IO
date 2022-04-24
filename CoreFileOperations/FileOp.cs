namespace CoreFileOperations
{
    public class FileOp
    {
        public void FileExists()
        {
            string path=@"/home/vivek/bridgelabz/CoreFile_IO/CoreFileOperations/FileOp.cs";
            if(File.Exists(path))
            {
                Console.WriteLine($"File is present in {path} directory.");
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }
        }
    }
}