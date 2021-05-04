using System;

namespace Home_work_class4
{
    class Money
    {
        private int first;
        private int second;
        public int A
        {
            get
            {
                return first;
            }

            set
            {
                first = value;
            }
        }
        public int B
        {
            get
            {
                return second;
            }
            set
            {
                second = value;
            }
        }
        public int Sum
        {
            get
            {
                return A + B;
            }
            private set { }
        }

        
        public Money(int a, int b) { first = a;second = b; }



        public void Allmoney()
        {
            Console.WriteLine($"Номиналы:{first}, количество{second}");
        }
        public bool Youcan(int a, int b, int c)
        {
            bool temp=false;
            if (a*b>=c)
            {
                Console.WriteLine("Да, вы можете себе это позволить");
                temp = true;
            }
            else if (a * b < c)
            {
                Console.WriteLine("К сожалению у вас не достаточно средств.");
                temp = false;
            }
            return temp;
        }
        public void Howmuch(int a, int b, int c, bool d)
        {
            if (d==true)
            {
                int howMuch = (a * b) / c;
                Console.WriteLine($"Вы можете купить {howMuch} штук");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите номиналы.");
            int nominals = Num();
            Console.WriteLine("Укажите количество.");
            int quantity = Num();
            Money info = new Money(nominals,quantity);
            Console.WriteLine("Укажите цену товара.");
            int productPrice = Num();
            bool result = info.Youcan(nominals, quantity, productPrice);
            info.Howmuch(nominals, quantity, productPrice, result);
            Console.ReadKey();
        }
        static int Num()
        {
            int num = 0;
            for (; ; )
            {
                string read1 = (Console.ReadLine());
                int.TryParse(read1, out num);
                if (num<0)
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
