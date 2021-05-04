using System;

namespace Home_work_class2_
{
    class Triangle
    {
        private int a;
        private int b;
        private int c;
        
        public int A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
        public int B
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }
        public int C
        {
            get
            {
                return c;
            }
            set
            {
                c = value;
            }
        }
        public bool isTriangle
        {
            get
            {
                if (a+b>c&&a+c>b&&b+c>a)
                {
                    return true;
                }
                return false;
            }
            private set { }
        }

        
        public Triangle (int x, int y, int z) { a = x; b = y; c = z; }
        public void Sidelengths()
        {
            Console.WriteLine($"Стороны треугольника:{a} {b} {c}");
        }
        public void Perimeter()
        {
            if (isTriangle ==true)
            {
                int perimeter = a + b + c;
                Console.WriteLine($"Периметр треугольника: {perimeter}");
            }
            else
            {
                Console.WriteLine("Такого треугольника не бывает.");
            }
        }
        public double Area()
        {
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine($"Площадь треугольника: {area}");
            return area;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            int a= Num("a");
            int b= Num("b");
            int c= Num("c");
            Triangle info = new Triangle(a,b,c);
            info.Sidelengths();
            info.Perimeter();
            double area = info.Area();
            Console.ReadKey();
        }
        static int Num(string a)
        {
            Console.WriteLine($"Укажите сторону треуголника {a}:");
            int num = 0;
            for (; ; )
            {
                string read1 = (Console.ReadLine());
                num = 0;
                int.TryParse(read1, out num);
                if (num <= 0)
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
