using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            Random random = new Random();
            Console.WriteLine("Введите n");
            n = EnterNumber();
            Console.WriteLine("Введите m");
            m = EnterNumber();
            int[,] matrix = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = random.Next(999);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j].ToString().PadLeft(4));
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        private static int EnterNumber()
        {
            int n;
            while (true)
            {
                try
                {
                    n = int.Parse(Console.ReadLine());
                    return n;
                }
                catch
                {
                    Console.WriteLine("Введены неверные данные");
                }
            }
        }
    }
}
