using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_21
{
    class Program
    {
        const int n = 5, m = 6;
        static int[,] sad = new int[n, m]; //{ { 1000, 3070, 850, 375, 1 }, { 1500, 200, 58, 245, 76, 345 } };

        static void Main(string[] args)
        {
            ThreadStart threadStart = new ThreadStart(Gardner1);
            Thread thread = new Thread(threadStart);
            thread.Start();

            Gardner2();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{sad[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        static void Gardner1()
        {

            for (int i = 0; i < n; i++)

                for (int j = 0; j < m; j++)
                    if (sad[i, j] == 0)
                    {
                        sad[i, j] = 1;
                        Thread.Sleep(2);
                    }
        }
        static void Gardner2()
        {
            for (int j1 = 1; j1 <= m; j1++)
                for (int i1 = 1; i1 <= n; i1++)

                    if (sad[n - i1, m - j1] == 0)
                    {
                        sad[n - i1, m - j1] = 2;
                        Thread.Sleep(2);
                    }
        }
    }
}