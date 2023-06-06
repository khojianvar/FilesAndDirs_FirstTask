using System.Text;

namespace FilesAndDirs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region FirstTask
            /*Console.Write("Enter path: ");
            var path = Console.ReadLine();
            var directories = Directory.GetDirectories(path);
            var files = Directory.GetFiles(path);
            int counterFile = 0;
            int counterDir = 0;
            foreach (var s in directories)
            {
                counterDir++;
            }
            foreach (var s in files)
            {
                counterFile++;
            }

            if (counterDir > 0 && counterFile > 0)
            {
                Console.WriteLine("--- Files and Dirs ---\n");
                foreach(var s in directories)
                {
                    Console.WriteLine(s);
                }
                foreach (var s in files)
                {
                    Console.WriteLine(s);
                }
            }else if(counterDir > 0 && counterFile == 0)
            {
                Console.WriteLine("--- Dirs ---");
                foreach (var s in directories)
                {
                    Console.WriteLine(s);
                }
            }
            else if (counterDir == 0 && counterFile > 0)
            {
                Console.WriteLine("--- Files ---");
                foreach (var s in files)
                {
                    Console.WriteLine(s);
                }
            }
            else
            {
                Console.WriteLine("--- Dir is empty ---");
            }*/
            #endregion

            #region SecondTask
            /*Console.Write("Enter path: ");
            FileInfo fileInfo = new FileInfo($"{Console.ReadLine()}");
            var lineCount = File.ReadAllLines($"{fileInfo}").Length;
            Console.WriteLine(lineCount);*/
            #endregion

            #region ThirdTask
            /*Console.Write("Enter file`s path which you want to copy: \n");
            FileInfo fileInfo = new FileInfo($"{Console.ReadLine()}");

            if (fileInfo.Exists)
            {
                Console.Write("Enter file`s path which you want to paste copiest file: ");
                fileInfo.CopyTo($"{Console.ReadLine()}", true);
            }
            else
            {
                Console.WriteLine("There is no entered file");
            }*/
            #endregion

            #region FourthTask
            /*Console.Write("Enter first file path: ");
            string file = $"{Console.ReadLine()}";
            Console.Write("Enter second file path: ");
            string newFile = $"{Console.ReadLine()}";

            var files = new[] { file, newFile };
            var builder = new StringBuilder();

            foreach (var f in files)
                builder.Append(File.ReadAllText(f));
            Console.Write("Enter united(first and second) file path: ");
            string unitedFile = $"{Console.ReadLine()}";
            File.WriteAllText(unitedFile, builder.ToString());*/
            #endregion


        }
    }
}