using System;

namespace comp
{
    public class FileWork
    {
        private string file = "";

        public void ScanFile()
        {
            file = Console.ReadLine();
        }

        public string PrintFile()
        {
            return file;
        }
    }
}
