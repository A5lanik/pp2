using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarManager
{
    enum FSIMode
    {
        DirectoryInfo = 1,
        File = 2
    }

    class Layer
    {
        public FileSystemInfo[] Content
        {
            get;
            set;
        }
        public int SelectedIndex
        {
            get;
            set;
        }
        public void Draw()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            for (int i = 0; i < Content.Length; ++i)
            {
                if (i == SelectedIndex)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine(Content[i].Name);
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\A5LAN\Desktop\pp2");
            Layer l = new Layer
            {
                Content = dir.GetFileSystemInfos(),
                SelectedIndex = 0
            };


            FSIMode curMode = FSIMode.DirectoryInfo;

            Stack<Layer> history = new Stack<Layer>();
            history.Push(l);

            bool esc = false;
            while (!esc)
            {
                if (curMode == FSIMode.DirectoryInfo)
                {
                    history.Peek().Draw();
                }
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        history.Peek().SelectedIndex--;
                        break;
                    case ConsoleKey.DownArrow:
                        history.Peek().SelectedIndex++;
                        break;
                    case ConsoleKey.Escape:
                        esc = true;
                        break;
                }
            }
        }
    }
}