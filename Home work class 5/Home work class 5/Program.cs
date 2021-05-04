using System;

namespace Home_work_class_5
{
    class Array
    {
        private int[] intArray;
        private int n;
        


        public int N
        {
            get
            {
                return n;
            }
        }

        public Array(int N)
        {
            this.n = N;
            intArray = new int[N];

        }
        public int Scalar
        {
            set
            {
                for (int i = 0; i < intArray.Length; i++)
                {
                    intArray[i] *= value;
                    Console.WriteLine(intArray[i]);
                } 
            }
        }

        public void Elements()
        {
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i]=Num($"элемент {i}");
            }
        }
        public int Num(string a)
        {
            Console.WriteLine($"Укажите {a}:");
            int num = 0;
            for (; ; )
            {
                string read1 = (Console.ReadLine());
                bool temp = int.TryParse(read1, out num);
                if (temp == false)
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
        public void Getinfo()
        {
            foreach (int nums in intArray)
            {
                Console.WriteLine(nums);
            }
        }
        public void Bubble()
        {
            for (int i = 0; i < intArray.Length-1; i++)
            {
                for (int j = i+1; j < intArray.Length; j++)
                {
                    if (intArray[i]>intArray[j])
                    {
                        int temp = intArray[i];
                        intArray[i] = intArray[j];
                        intArray[j] = temp;
                    }
                }
            }
            Console.WriteLine("Отсортировка завершена.");
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            int length =  Num("длину массива");
            

            Array myArray = new Array(length);
            myArray.Elements();
            myArray.Getinfo();
            myArray.Bubble();
            myArray.Getinfo();
            int scalar = Num("Скаляр");
            myArray.Scalar = scalar;
            Console.ReadKey();
        }
        static int Num(string a)
        {
            Console.WriteLine($"Укажите {a}:");
            int num = 0;
            for (; ; )
            {
                string read1 = (Console.ReadLine());
                bool temp = int.TryParse(read1, out num);
                if (temp == false)
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
