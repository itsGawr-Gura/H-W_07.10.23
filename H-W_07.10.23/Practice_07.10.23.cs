using System;
using System.Collections.Generic;
using System.Linq;

namespace H_W_07._10._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1 Перемешивание картинок
            Console.WriteLine("Задание 1 Перемешивание картинок");
            List<int> initList = Enumerable.Range(1, 64).ToList();
            List<string> images = new List<string>()
            {
            "1 (1)", "1 (1)",
            "1 (2)", "1 (2)",
            "1 (3)", "1 (3)",
            "1 (4)", "1 (4)",
            "1 (5)", "1 (5)",
            "1 (6)", "1 (6)",
            "1 (7)", "1 (7)",
            "1 (8)", "1 (8)",
            "1 (9)", "1 (9)",
            "1 (10)", "1 (10)",
            "1 (11)", "1 (11)",
            "1 (12)", "1 (12)",
            "1 (13)", "1 (13)",
            "1 (14)", "1 (14)",
            "1 (15)", "1 (15)",
            "1 (16)", "1 (16)",
            "1 (17)", "1 (17)",
            "1 (18)", "1 (18)",
            "1 (19)", "1 (19)",
            "1 (20)", "1 (20)",
            "1 (21)", "1 (21)",
            "1 (22)", "1 (22)",
            "1 (23)", "1 (23)",
            "1 (24)", "1 (24)",
            "1 (25)", "1 (25)",
            "1 (26)", "1 (26)",
            "1 (27)", "1 (27)",
            "1 (28)", "1 (28)",
            "1 (29)", "1 (29)",
            "1 (30)", "1 (30)",
            "1 (31)", "1 (31)",
            "1 (32)", "1 (32)",
            };
            Random rnd = new Random();
            List<string> shuffImages = images.OrderBy(x => rnd.Next()).ToList();
            Console.WriteLine("Изначальный List с номерами:");
            foreach (int number in initList)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Перемешанный List с картинками:");
            foreach (string image in shuffImages)
            {
                Console.Write(image + " ");
            }
            Console.WriteLine("");
            //Задание 4 Обход Графа
            Console.WriteLine("Задание 4 Обход Графа");


            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey();
        }


    }
}

