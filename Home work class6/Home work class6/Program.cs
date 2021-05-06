using System;

namespace Home_work_class6
{
    class NewArray
    {
        double[,] doubleArray;
        int n;
        int m;

        public int N
        {
            get
            {
                return n;
            }
            set
            {
                n = value;
            }
        }
        public int M
        {
            get
            {
                return m;
            }
            set
            {
                m = value;
            }
        }

        public int Elements
        {
            get
            {
                return doubleArray.Length;
            }
            private set
            {
                
            }
        }
        public double Scalar
        {
            private get
            {
                return doubleArray[n,m];
            }
            set
            {
                for (int i = 0; i < doubleArray.GetLength(0); i++)
                {
                    for (int j = 0; j < doubleArray.GetLength(1); j++)
                    {
                        doubleArray[i,j] += value;
                    }
                    
                }
            }
        }
        public NewArray(int M, int N)
        {
            m = M;
            n = N;
            doubleArray = new double[m, n];
        }
        static double Num(string a)
        {
            Console.WriteLine($"Укажите {a}:");
            double num = 0;
            for (; ; )
            {
                string read1 = (Console.ReadLine());
                bool temp = double.TryParse(read1, out num);
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
        public void Fillelements()
        {
            for (int i = 0; i < doubleArray.GetLength(0); i++)
            {
                for (int j = 0; j < doubleArray.GetLength(1); j++)
                {
                    doubleArray[i, j] = Num($"Укажите элемент: {i} , {j}");
                }
            }
        }
        public void Getprint()
        {
            for (int i = 0; i < doubleArray.GetLength(0); i++)
            {
                for (int j = 0; j < doubleArray.GetLength(1); j++)
                {
                    Console.Write($"{i}, {j}= {doubleArray[i, j]} \t");
                }
                Console.WriteLine();
            }
        }
        public void Bubble()
        {
            Console.WriteLine("Массив после сортировки:");
            for (int i = 0; i < doubleArray.GetLength(0); i++)
            {
                for (int j = 0; j < doubleArray.GetLength(1)-1; j++)
                {
                    for (int k =j+1; k < doubleArray.GetLength(1); k++)
                    {
                        if (doubleArray[i, j] < doubleArray[i, k])
                        {
                            double temp = doubleArray[i, j];
                            doubleArray[i, j] = doubleArray[i, k];
                            doubleArray[i, k] = temp;

                        }
                    }

                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int firstIndex = Num("длину первой меры.");
            int secondIndex = Num("длину второй мерыю");
            NewArray myArray = new NewArray(firstIndex, secondIndex);
            myArray.Fillelements();
            myArray.Getprint();
            Console.WriteLine($"Общее количество элементов: {myArray.Elements}");
            myArray.Bubble();
            myArray.Getprint();
            int scalar = Num("скаляр.");
            myArray.Scalar = scalar;
            myArray.Getprint();
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
