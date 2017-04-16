using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Wall : GameObject
    {
        Game game = null;

        public void AttachGameLink(Game game)
        {
            this.game = game;
        }

        public Wall()
        {
            this.sign = '#';
        }

        public void Info()
        {
            Console.WriteLine(game.score);
        }

        public void Generate(int level)
        {

            this.points.Clear();
            string fname = string.Format(@"Levels\level{0}.txt", level);
            using (FileStream fs = new FileStream(fname, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    int colNumber = 0;
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        for (int rowNumber = 0; rowNumber < line.Length; ++rowNumber)
                        {
                            if (line[rowNumber] == '#')
                            {
                                this.points.Add(new Point(rowNumber, colNumber));

                            }
                        }

                        colNumber++;
                    }
                }
            }
        }
    }
}