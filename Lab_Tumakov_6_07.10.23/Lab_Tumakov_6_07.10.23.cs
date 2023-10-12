using System;
using System.Collections.Generic;
using System.IO;

namespace Lab_Tumakov_6_07._10._23
{

    internal class Program
    {
        public static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
        {
            int rows1 = matrix1.GetLength(0);
            int cols1 = matrix1.GetLength(1);
            int rows2 = matrix2.GetLength(0);
            int cols2 = matrix2.GetLength(1);

            if (cols1 != rows2)
            {
                throw new ArgumentException("Размер матрицы не подходит под вычесления");
            }

            int[,] result = new int[rows1, cols2];

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    int sum = 0;

                    for (int k = 0; k < cols1; k++)
                    {
                        sum += matrix1[i, k] * matrix2[k, j];
                    }

                    result[i, j] = sum;
                }
            }

            return result;
        }
        static double[] CalculateAverageTemperatures(double[,] temperature)
        {
            double[] averageTemperatures = new double[12];
            for (int month = 0; month < 12; month++)
            {
                double sum = 0;
                for (int day = 0; day < 30; day++)
                {
                    sum += temperature[month, day];
                }
                averageTemperatures[month] = sum / 30;
            }
            return averageTemperatures;
        }
        static void Main(string[] args)
        {
            // Задание 6.1 Количество гласных и согласных
            Console.WriteLine("Задание 6.1 Количество гласных и согласных");
            string path = "File.txt";
            // string vow = "eyuiaoйуеыаоэияё"; перед изменением
            List<char> vow = new List<char>() { 'e', 'y', 'u', 'i', 'o', 'a', 'й', 'ё', 'у', 'е', 'ы', 'а', 'о', 'э', 'ю', 'и', 'я' };
            // string cons = "qwrtplkjhgfdszxcvbnmцкнгшщзхъждлрпвфчсмтьб"; перед изменением
            List<char> cons = new List<char>() { 'q', 'w', 'r', 't', 'p', 'l', 'k', 'j', 'h', 'g', 'f', 'd', 's', 'z', 'x', 'c', 'v', 'b', 'n', 'm', 'ц', 'к', 'н', 'г', 'ш', 'щ', 'з', 'х', 'ж', 'ъ', 'д', 'л', 'р', 'п', 'в', 'ф', 'ч', 'с', 'м', 'т', 'ь', 'б' };
            int sumvow = 0;
            int sumcons = 0;
            string filetext = File.ReadAllText(path);
            filetext = filetext.ToLower();
            foreach (char c in filetext)
            {
                foreach (char c2 in vow)
                    if (c == c2)
                    {
                        sumvow++;
                    }
                foreach (char c3 in cons)
                    if (c == c3)
                    {
                        sumcons++;
                    }

            }
            Console.WriteLine("Исходный файл содержит следующие данные -");
            Console.WriteLine(filetext);
            Console.WriteLine($"Количество гласных = {sumvow}, а количество согласных = {sumcons}");
            // Задание 6.2 Умножение двух матриц
            int[,] matrix1 =
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };
            int[,] matrix2 =
        {
            {10, 11, 12},
            {13, 14, 15},
            {16, 17, 18}
        };
            int[,] result = MultiplyMatrices(matrix1, matrix2);
            Console.WriteLine("Матрица 1:");
            PrintMatrix(matrix1);
            Console.WriteLine("Матрица 2:");
            PrintMatrix(matrix2);
            Console.WriteLine("Результат умножения:");
            PrintMatrix(result);
            // Задание 6.3 Средняя температура
            Console.WriteLine("Задание 6.3 Средняя температура");
            double[,] temperature = new double[12, 30];
            Random random = new Random();
            for (int month = 0; month < 12; month++)
            {
                for (int day = 0; day < 30; day++)
                {
                    temperature[month, day] = random.NextDouble() * 40;
                }
            }
            double[] averageTemperatures = CalculateAverageTemperatures(temperature);
            for (int month = 0; month < 12; month++)
            {
                Console.WriteLine($"Средняя температура для месяца {month + 1}: {averageTemperatures[month]}");
            }
            Array.Sort(averageTemperatures);
            Console.WriteLine("Отсортированный массив средних температур:");
            foreach (double temperatures in averageTemperatures)
            {
                Console.WriteLine(temperatures);
            }
            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey();
        }






    }

}














