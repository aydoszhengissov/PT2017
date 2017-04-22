using System;
using System.IO;

namespace FarManager
{
    class MainClass
    {
        static void ShowInfo(DirectoryInfo directory, int cursor)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            int index = 0;
            foreach (FileSystemInfo fi in directory.GetFileSystemInfos())
            {
                if (index == cursor)
                    Console.ForegroundColor = ConsoleColor.Blue;
                else
                    Console.ForegroundColor = ConsoleColor.White;
                index++;
                Console.WriteLine(fi.Name);
            }
        }

        static void Main(string[] args)
        {
            int cursor = 0;
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\admin12\Documents\FIFA 15");
            while (true)
            {
                Console.Clear();
                ShowInfo(directory, cursor);
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                if (pressedKey.Key == ConsoleKey.UpArrow)
                {
                    if (cursor > 0)
                    {
                        cursor--;
                    }
                }
                if (pressedKey.Key == ConsoleKey.DownArrow)
                {
                    if (cursor < directory.GetFileSystemInfos().Length - 1)
                    {
                        cursor++;
                    }
                }
                if (pressedKey.Key == ConsoleKey.Enter)
                {
                    FileSystemInfo fi = directory.GetFileSystemInfos()[cursor];
                    if (fi.GetType() == typeof(DirectoryInfo))
                    {
                        directory = new DirectoryInfo(fi.FullName);
                        cursor = 0;
                    }

                    else
                    {
                        string ext = Path.GetExtension(fi.FullName);
                        if (ext == ".txt")
                        {
                            Console.Clear();
                            StreamReader sr = new StreamReader(fi.FullName);
                            Console.WriteLine(sr.ReadToEnd());
                            sr.Close();
                            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
                            {
                                // do nothing until escape!
                            }
                        }
                    }
                }
                if (pressedKey.Key == ConsoleKey.Escape)
                {
                    directory = Directory.GetParent(directory.FullName);
                }
                if (pressedKey.Key == ConsoleKey.Backspace)
                    break;
            }
        }
    }
}