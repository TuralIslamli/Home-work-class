using System;

namespace Home_work_class3
{
    class Rectangle
    {
       private int a;
       private int b;

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
        public bool isSquared
        {
            get 
            { 

                if (A == B)
                {
                    return true;
                }
                return false;

            }
            private set { }
            
        }

        

        public Rectangle (int x, int y) { a = x;b = y; }

        public void Sideslength()
        {
            Console.WriteLine($"Стороны прямоуголника:{a}, {b}");
        }
        public void Perimeter()
        {
            int perimeter = 0;
            if (isSquared==true)
            {
                Console.WriteLine("Это квадрат.");
                perimeter = (a + b) * 2;
                Console.WriteLine($"Периметр квадрата {perimeter}");
            }
            else
            {
                perimeter = (a + b) * 2;
                Console.WriteLine($"Периметр прямоугольника {perimeter}");
            }
           
        }
        public void Area()
        {
            int area = a * b;
            Console.WriteLine($"Площадь равен {area}");
            
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int a= Num("a");
            int b= Num("b");
            Rectangle info = new Rectangle(a,b);
             
            
            info.Sideslength();
            info.Perimeter();
            info.Area();
            Console.ReadKey();
        }


        static int Num(string a)
        {
            Console.WriteLine($"Укажите сторону прямоугольника {a}:");
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
