namespace CoreFileOperations
{
    public class FileOp
    {
        string path = @"/home/vivek/bridgelabz/CoreFile_IO/CoreFileOperations/MyFile.txt";
        public void FileExists()
        {
            if (File.Exists(path))
            {
                Console.WriteLine($"File is present in {path} directory. \n");
            }
            else
            {
                Console.WriteLine("File does not exist. \n");
            }
        }
        public void ReadAllLines()
        {
            string lines;
            if (File.Exists(path))
            {
                lines = File.ReadAllText(path);
                Console.WriteLine(lines);
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }
        }


    }
}