using System;

namespace Klassi_test
{
    class Point
    {
        private int x;
        private int y;

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x=value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y=value;
            }
        }
        public int ScalXY
        {
            set
            {
                x = x * value;
                y = y * value;
                Console.WriteLine($"{x},{y}");
            }
        }
        


        public Point() {}
        public Point(int a, int b) {this.x = a; this.y = b; }
        public void Coordinates()
        {
            Console.WriteLine($"Координаты {x},{y}");
        }
        public double Startcoord()
        {
            double startCoord = x * x + y * y;
            startCoord = Math.Sqrt(startCoord);
            Console.WriteLine($"Расстояние от начала координат до точки:{ startCoord}");
            return startCoord;

        }

        public void Vektor(int a, int b)
        {
            x += a;
            y += b;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Point info = new Point();
            info.Coordinates();
            int a = Num("x");
            int b = Num("y");
            info = new Point(a, b);
            info.Coordinates();
            double startCoord = info.Startcoord();
            int scalarNum = Num("Скаляр");
            info.ScalXY = scalarNum;
            int vekA = Num("число оси х");
            int vekB = Num("число оси y");
            info.Vektor(vekA, vekB);
            info.Coordinates();

            Console.ReadKey();
        }
        static int Num(string a)
        {
            Console.WriteLine($"Укажите {a}:");
            int num = 0;
            for (; ; )
            {
                string read1 = (Console.ReadLine());
                bool temp=int.TryParse(read1, out num);
                if (temp==false)
                {
                    Console.WriteLine("Не правильно, укажите правильную информацию.");
                }
                else
                {
                    break;
                }
            }
            return num;
        }
    }
}
