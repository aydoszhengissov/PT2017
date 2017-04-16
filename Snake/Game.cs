using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    public class Game
    {
        public Worm worm = null;
        public Wall wall = null;
        public Food food = null;
        public bool isAlive = true;
        Thread t = null;

        public int score;
        public int level = 1;
        public bool nextLevel = false;

        public void CanEat()
        {
            if (worm.points[0].Equals(food.points[0]))
            {
                worm.points.Add(food.points[0]);
                food = new Food();
                food.Generate(wall, worm);
                food.Draw();

                score = score + 100;
                if (score == 500)
                    nextLevel = true;
            }

        }

        public void CheckBorder()
        {
            for (int i = 0; i < wall.points.Count; i++)
            {
                if (worm.points[0].Equals(wall.points[i]))
                {
                    Environment.Exit(0);
                }
            }
        }

        public void Draw()
        {
            worm.Draw();
            wall.Draw();
        }

        public void Save()
        {
            worm.Save();
            wall.Save();
        }

        public void Load()
        {
            worm = new Worm();
            worm.AttachGameLink(this);

            wall = new Wall();
            food = new Food();
            food.Generate(wall, worm);
            worm.Generate(wall);
            wall.Generate(level);
            worm.Draw();
            wall.Draw();
            food.Draw();
        }

        public void Start()
        {
            Load();


            Thread t = new Thread(new ThreadStart(worm.Move));
            t.Start();

            while (true)
            {
                wall.Save();
                if (score == 500 && nextLevel == true)
                {
                    level = level + 1;
                    wall.Clear();
                    wall.Generate(level);
                    wall.Draw();
                    nextLevel = false;
                    score = 0;

                    worm.Clear();
                    Point p = new Point();
                    p = worm.points[0];
                    worm.points.Clear();
                    worm.points.Add(p);


                }

                ConsoleKeyInfo pressedKey = Console.ReadKey();
                switch (pressedKey.Key)
                {
                    case ConsoleKey.F2:
                        this.Save();
                        break;
                    case ConsoleKey.F3:
                        wall = wall.Load() as Wall;
                        wall.Draw();
                        worm.Clear();
                        worm = worm.Load() as Worm;
                        worm.AttachGameLink(this);
                        t.Abort();

                        t = new Thread(new ThreadStart(worm.Move));
                        t.Start();
                        break;
                    case ConsoleKey.UpArrow:
                        worm.dx = 0;
                        worm.dy = -1;
                        break;
                    case ConsoleKey.DownArrow:
                        worm.dx = 0;
                        worm.dy = 1;
                        break;
                    case ConsoleKey.LeftArrow:
                        worm.dx = -1;
                        worm.dy = 0;
                        break;
                    case ConsoleKey.RightArrow:
                        worm.dx = 1;
                        worm.dy = 0;
                        break;
                    case ConsoleKey.Escape:
                        break;
                }

            }
        }
    }
}