using System.Data;

namespace CoreFileOperations
{
    class StreamOperationsRW
    {
        public void ReadFromStreamReader()
        {
            Console.WriteLine("========== STREAM READ =========");
            string path = @"/home/vivek/bridgelabz/CoreFile_IO/CoreFileOperations/MyFile.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}