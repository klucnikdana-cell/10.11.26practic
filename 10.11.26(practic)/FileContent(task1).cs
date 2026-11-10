using System;
using System.Collections.Generic;
using System.Text;

namespace _10._11._26_practic_
{
    internal class FileContent
    {
        public void FileContenting(string path)
        {
            if (File.Exists(path))
            {
                string content = File.ReadAllText(path);
                Console.WriteLine($"Content: {content}");
            }
            else
            {
                Console.WriteLine("File not exist");
            }
        }
    }
}
