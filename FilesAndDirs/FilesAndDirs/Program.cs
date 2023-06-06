namespace FilesAndDirs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var paths = Directory.GetCurrentDirectory();
            Console.WriteLine(paths);

            string path = "C:\\Users\\User\\Desktop\\cw\\Files\\Files";
            string file = "C:\\Users\\User\\Desktop\\cw\\Files\\.getignore.txt";

            // 1-Task

            if (!File.Exists(file))
            {
                File.Create(file);
            }

            // 2-Task

            string[] dirs = Directory.GetDirectories(path, "bin*");
            string[] dir = Directory.GetDirectories(path, "obj*");

            Console.WriteLine("--- Dirs ---");

            foreach (string s in dirs)
            {
                Console.WriteLine(s);
            }
            foreach (string s in dir)
            {
                Console.WriteLine(s);
            }

            // 3-Task

            Console.WriteLine("--- Files ---");

            string[] files = Directory.GetFiles(path, "*.cs");

            foreach (string s in files)
            {
                Console.WriteLine(s);
            }

            // 4-Task

            Console.WriteLine("Enter path: ");
            string path1 = Console.ReadLine();

            string[] dirs1 = Directory.GetDirectories(path1, "bin*");
            string[] dir1 = Directory.GetDirectories(path1, "obj*");

            foreach (string str in dirs1)
            {
                Directory.Delete(str, true);
            }
            foreach (string str in dir1)
            {
                Directory.Delete(str, true);
            }
        }
    }
}