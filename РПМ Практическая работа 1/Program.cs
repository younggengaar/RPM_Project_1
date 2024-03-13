using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace РПМ_Практическая_работа_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            c:
            Console.Write("Введите номер задания:");
            int n= int.Parse(Console.ReadLine());
            switch(n)
            {
                case 1:
                    {
                        Console.WriteLine("Ввычислить среднее значение элементов массива из n чисел.");
                        Console.Write("Введите размер массива:");
                        int kol = int.Parse(Console.ReadLine());
                        int[]numb = new int[kol];
                        int sum = 0;
                        int count = 0;
                        for (int i = 0;i<kol;i++)
                        {
                            Console.Write($"Введите {i + 1} элемент массива:");
                            numb[i] = int.Parse(Console.ReadLine());
                            count++;
                        }
                        foreach(int num in numb)
                        {
                            sum += num;
                        }
                        double sr_arf = sum / count;
                        Console.WriteLine($"Среднее значение {sr_arf}");
                        Console.ReadKey();
                    }
                    goto c;
            }
        }
    }
}
