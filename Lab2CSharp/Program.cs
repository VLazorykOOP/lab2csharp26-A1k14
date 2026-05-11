using System;

namespace LabWork2
{
    class Program
    {
        static void Main()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\n LAB 2, ( 1 - 4 ) ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Task1();
                        break;
                    case "2":
                        Task2();
                        break;
                    case "3":
                        Task3();
                        break;
                    case "4":
                        Task4();
                        break;
                    case "0":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("wrong ");
                        break;
                }
            }
        }

        static void Task1()
        {
            Console.Write("n: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                int[] array = new int[n];
                Console.WriteLine("elements:");

                for (int i = 0; i < n; i++)
                {
                    Console.Write($"array[{i}] = ");
                    while (!int.TryParse(Console.ReadLine(), out array[i]))
                    {
                        Console.Write($"only 123457890.");
                    }
                }

                Console.WriteLine("parni index:");
                for (int i = 0; i < n; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write($"{array[i]} ");
                    }
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("masiv only +0");
            }
        }

        static void Task2()
        {
            Console.Write(" n: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 1)
            {
                double[] array = new double[n];
                Console.WriteLine("elements:");

                for (int i = 0; i < n; i++)
                {
                    Console.Write($"array[{i}] = ");
                    while (!double.TryParse(Console.ReadLine(), out array[i]))
                    {
                        Console.Write($"only 123457890.[{i}]: ");
                    }
                }

                int pairCount = 0;
                for (int i = 0; i < n - 1; i++)
                {
                    if (array[i] % array[i + 1] == 0)
                    {
                        pairCount++;
                    }
                }

                Console.WriteLine($"Answer pairs: {pairCount}");
            }
            else
            {
                Console.WriteLine("only 123457890. not minus");
            }
        }


        static void Task3()
        {
            Console.Write("n : ");

            if (int.TryParse(Console.ReadLine(), out int n) && n > 1)
            {
                Console.WriteLine("\nmatriza");
                int[,] matrix2D = new int[n, n];
                Console.WriteLine("elements:");

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write($"matrix2D[{i},{j}] = ");
                        while (!int.TryParse(Console.ReadLine(), out matrix2D[i, j]))
                        {
                            Console.Write($"only 123457890 ");
                        }
                    }
                }

                int sum2D = 0;
                int count2D = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i + j > n - 1)
                        {
                            sum2D += matrix2D[i, j];
                            count2D++;
                        }
                    }
                }

                if (count2D > 0)
                {
                    double mean2D = (double)sum2D / count2D;
                    Console.WriteLine($"Serednie arihmeti for matrix: {mean2D}");
                }

                int[] matrix1D = new int[n * n];
                Console.WriteLine("elements for masive :");

                for (int k = 0; k < n * n; k++)
                {
                    int i = k / n;
                    int j = k % n;
                    Console.Write($"matrix1D[{i},{j}] = ");
                    while (!int.TryParse(Console.ReadLine(), out matrix1D[k]))
                    {
                        Console.Write($"only 123457890. ");
                    }
                }

                int sum1D = 0;
                int count1D = 0;
                for (int k = 0; k < n * n; k++)
                {
                    int i = k / n;
                    int j = k % n;

                    if (i + j > n - 1)
                    {
                        sum1D += matrix1D[k];
                        count1D++;
                    }
                }

                if (count1D > 0)
                {
                    double mean1D = (double)sum1D / count1D;
                    Console.WriteLine($"Serednie arihmeti for masive : {mean1D}");
                }
            }
            else
            {
                Console.WriteLine("wrong");
            }
        }
        static void Task4()
        {
            Console.Write(" n (n > 0): ");

            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                int[][] jaggedArray = new int[n][];
                int maxColumns = 0;

                for (int i = 0; i < n; i++)
                {
                    Console.Write($"elements in a row {i} (m > 0): ");
                    int m;
                    while (!int.TryParse(Console.ReadLine(), out m) || m <= 0)
                    {
                        Console.Write("wrong ");
                    }

                    jaggedArray[i] = new int[m];

                    if (m > maxColumns)
                    {
                        maxColumns = m;
                    }

                    Console.WriteLine($"elements for row{i}:");
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write($"jaggedArray[{i}][{j}] = ");
                        while (!int.TryParse(Console.ReadLine(), out jaggedArray[i][j]))
                        {
                            Console.Write("wrong ");
                        }
                    }
                }

                int[] resultColumns = new int[maxColumns];

                for (int col = 0; col < maxColumns; col++)
                {
                    int currentSum = 0;
                    for (int row = 0; row < n; row++)
                    {
                        if (col < jaggedArray[row].Length)
                        {
                            if (jaggedArray[row][col] > 0 && jaggedArray[row][col] % 2 == 0)
                            {
                                currentSum += jaggedArray[row][col];
                            }
                        }
                    }
                    resultColumns[col] = currentSum;
                }

                Console.WriteLine("\nThe resulting array of the sums of paired positive elements by column:");
                for (int col = 0; col < maxColumns; col++)
                {
                    Console.Write($"{resultColumns[col]} ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("wrong");
            }
        }
    }
}