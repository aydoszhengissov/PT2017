
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Food : GameObject
    {
        public Point FoodLocation;
        public Food()
        {
            this.sign = '♠';

        }

        public void Generate(Wall wall, Worm worm)
        {
            this.points.Clear();
            Point newFood = new Point(new Random().Next() % 30, new Random().Next() % 30);
            FoodLocation = newFood;
            while (wall.points.Contains(newFood) || worm.points.Contains(newFood))
            {
                newFood = new Point(new Random().Next() % 30, new Random().Next() % 30);
                FoodLocation = newFood;
            }

            this.points.Add(FoodLocation);
        }
    }
}