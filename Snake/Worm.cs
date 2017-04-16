using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    public class Worm : GameObject
    {
        Game game = null;
        public int dx;
        public int dy;
        public Point WormLocation;

        public void AttachGameLink(Game game)
        {
            this.game = game;
        }

        public void Generate(Wall wall)
        {
            Point newWorm = new Point(new Random().Next() % 28, new Random().Next() % 28);
            WormLocation = newWorm;

            while (wall.points.Contains(newWorm))
            {
                newWorm = new Point(new Random().Next() % 28, new Random().Next() % 28);
                WormLocation = newWorm;
            }
            this.points.Add(WormLocation);
        }

        public Worm()
        {
            this.sign = '*';
        }
        public void Move()
        {
            while (true)
            {
                if (points[0].x + dx < 0) continue;
                if (points[0].y + dy < 0) continue;
                if (points[0].x + dx > 40) continue;
                if (points[0].y + dy > 40) continue;

                Clear();

                for (int i = points.Count - 1; i > 0; --i)
                {
                    points[i].x = points[i - 1].x;
                    points[i].y = points[i - 1].y;
                }

                points[0].x = points[0].x + dx;
                points[0].y = points[0].y + dy;

                Draw();

                game.CanEat();
                game.CheckBorder();
                Thread.Sleep(100);
            }
        }
    }
}