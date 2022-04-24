using System.Data;

namespace CoreFileOperations
{
    class StreamOperationsRW
    {
        public void ReadFromStreamReader()          // method for reading content using StreamReader class
        {
            Console.WriteLine("========== STREAM READ =========");
            string path = @"/home/vivek/bridgelabz/CoreFile_IO/CoreFileOperations/MyFile.txt";
            using (StreamReader sr = File.OpenText(path))             // direct object initialization of StreamReader class
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)                 // until s becomes null print the content on console.
                {
                    Console.WriteLine(s);
                }
            }
        }
         public void WriteUsingStreamWriter()                       // method for reading content using StreamWriter class
        {
            Console.WriteLine("========== STREAM WRITE ========");
            string path = @"/home/vivek/bridgelabz/CoreFile_IO/CoreFileOperations/MyFile.txt";
            using (StreamWriter sw = File.AppendText(path))         // direct object initialization of StreamWriter class
            {
                sw.WriteLine("\nWe have added this line");
                sw.Close();                                         //close stream writer
                Console.WriteLine("File Write operation Successful ");
                Console.WriteLine("======= READ UPDATED FILE ======");
                Console.WriteLine(File.ReadAllText(path));          // reading appended content.
            }
        }
    }
}