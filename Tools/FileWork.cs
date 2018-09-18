using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tools
{
    public class FileWork
    {
        public IntQueue Read(string FileName) => StrToQueue(File.ReadAllText(FileName));
        public IntQueue StrToQueue(string Str)
        {
            string[] data = Str.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
            IntQueue queue = new IntQueue();
            foreach (var item in data)
            {
                queue.Enqueue(int.Parse(item));
            }
            return queue;
        }
        public void Write(string FileName, IntQueue queue) => File.WriteAllText(FileName, queue.ToString());
    }
}
