using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_实验二
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        //基类SHape
        class Shape
        {
            public int X;
            public int Y;
        }
        class circle:Shape
        {
            public int R;
            public int X;
            public int Y;

            public circle(int r, int x, int y)
            {
                X = x;
                Y = y;
                R = r;
            }

            public void Draw()
            {
                Console.WriteLine("圆形：圆心(" + X + "," + Y + ") 半径" + R);
            }

        }
        class clue:Shape
        {
            public int X;
            public int Y;

            public int length;
            public int height;

            public clue(int x ,int y ,int l ,int h)
            {
                X = x;
                Y = y;
                length = l;
                height = h;
            }
            public void Draw()
            {
                Console.WriteLine("矩形：位置(" + X + "," + Y + ") 长 " + length + " 宽 " + height);
            }
        }
        class NewShape
        {
            private List<Shape> _shapes = new List<Shape>();
            public void AddShape(Shape shape)
            {
                _shapes.Add(shape);
            }
        }
    }
}



