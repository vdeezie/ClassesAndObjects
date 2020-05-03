using System;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            r1.Height = 100;
            r1.Width = 100;
            r1.Color = "red";
            r1.Position = new Position();
            r1.Position.X = 0;
            r1.Position.Y = 0;
            

            Rectangle r2 = new Rectangle();
            r1.Height = 100;
            r1.Width = 200;
            r2.Color = "black";
            r2.Position = new Position();
            r1.Position.X = 5;
            r1.Position.Y = 10;
            

            bool isr1Square = IsShapeSquare(r1);
            bool isr2Square = IsShapeSquare(r2);

            bool isInSamePosition = IsInSamePosition(r1,r2);
            //Console.WriteLine(isInSamePosition);

            Console.WriteLine(isr1Square);
            Console.WriteLine(isr2Square);
        }

        static bool IsInSamePosition(Rectangle r1, Rectangle r2)
        {
            if(r1.Position.X == r2.Position.X && r1.Position.Y == r2.Position.Y)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        static bool IsShapeSquare(Rectangle r) 
        {
            if(r.Width == r.Height)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
