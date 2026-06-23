namespace MyFirstProject.Lessons
{
    public static class Lesson45_FileManagement
    {
        public static void Run()
        {
                string rootPath = Directory.GetCurrentDirectory();

            // //* Klasörleri al
            string[] dirs = Directory.GetDirectories(
                rootPath,
                "*",
                SearchOption.TopDirectoryOnly
            );

            foreach (string dir in dirs)
            {
                Console.WriteLine(dir);
            }

            // //* Dosyaları al
            string[] files = Directory.GetFiles(
                rootPath,
                "*",
                SearchOption.AllDirectories
            );

            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
            }
    }
}