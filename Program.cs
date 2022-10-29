using System.Linq;
using System;
using System.Collections.Generic;
using System.IO;

internal class Program
{
    public static void Main(string[] args)
    {
        work work = new work();
    }
}


class work
{


    public work()
    {
        while (true)
        {
            try
            {
                {
                    Console.WriteLine("Какое задание будет выполняться: 1, 2 или 3");
                    int c = int.Parse(Console.ReadLine());

                    if (c != 1 && c != 2 && c != 3)
                    {
                        Console.WriteLine("Такого задания не существует");
                    }

                    else
                    {
                        switch (c)
                        {
                            case 1:
                                task1();
                                break;
                            case 2:
                                task2();
                                break;
                            case 3:
                                task3();
                                break;

                        }
                    }
                }



            }
            catch
            {
                Console.WriteLine("Error");
            }

        }

    }

    virtual protected void task1()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Введите <b>, если хотите осуществить ввод через консоль или <k>, если через файл: ");
                string n = "";
                n = Console.ReadLine();

                if (n != "b" && n != "k")
                {
                    Console.WriteLine("Такой команды не существует");
                }
                else
                {
                    if (n == "b")
                    {
                        Console.WriteLine("Введите через пробел одномерный массив: ");

                        var Array_0 = Console.ReadLine().Trim().Split().Select(x => int.Parse(x)).ToArray();
                        int Max = Array_0[0];
                        int Min = Array_0[0];
                        int indexx, index, indexi, indexj;
                        indexx = index = indexi = indexj = 0;
                        for (int i = 1; i < Array_0.Length; i++)
                        {
                            if (Array_0[i] > Max)
                            {
                                Max = Array_0[i];
                                indexx = i;
                                Max = Array_0[indexi = i];
                            }
                        }

                        for (int j = 1; j < Array_0.Length; j++)
                        {
                            if (Array_0[j] < Min)
                            {
                                Min = Array_0[j];
                                index = 0;
                                Min = Array_0[indexj = j];
                            }
                        }

                        var Array_1 = Array_0.ToArray();
                        var Array_2 = Array_0.ToArray();





                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Введите 1 или 2 в зависимости от того, какой метод стортировки использовать: ");
                                int d = int.Parse(Console.ReadLine());



                                if (d != 1 && d != 2)
                                {
                                    Console.WriteLine("Такого задания не существует");
                                }
                                else
                                {
                                    switch (d)
                                    {
                                        case 1:

                                            foreach (int i2 in Buble.Bubble_up(Array_1))
                                            {
                                                Console.Write(i2 + " ");
                                            }
                                            Console.WriteLine();
                                            break;


                                        case 2:
                                            Array.Sort(Array_2);
                                            Array.Reverse(Array_2);
                                            foreach (int i3 in Array_2)
                                            {
                                                Console.Write(i3 + " ");
                                            }
                                            Console.WriteLine();
                                            break;

                                        default:
                                            break;
                                    }

                                }

                                break;

                            }
                            catch
                            {
                                Console.WriteLine("Error");
                            }


                        }
                    }





                    else
                    {
                        if (n == "k")
                        {
                            Console.WriteLine("Введите путь к этому файлу с указанием типа файла(.txt) ");
                            using var sr = new StreamReader(Console.ReadLine());


                            var w = sr.ReadLine();
                            var Array_0 = w.Trim().Split().Select(x => int.Parse(x)).ToArray();

                            int Max = Array_0[0];
                            int Min = Array_0[0];
                            int indexx, index, indexi, indexj;
                            indexx = index = indexi = indexj = 0;
                            for (int i = 1; i < Array_0.Length; i++)
                            {
                                if (Array_0[i] > Max)
                                {
                                    Max = Array_0[i];
                                    indexx = i;
                                    Max = Array_0[indexi = i];
                                }
                            }

                            for (int j = 1; j < Array_0.Length; j++)
                            {
                                if (Array_0[j] < Min)
                                {
                                    Min = Array_0[j];
                                    index = 0;
                                    Min = Array_0[indexj = j];
                                }
                            }

                            var Array_1 = Array_0.ToArray();
                            var Array_2 = Array_0.ToArray();


                            while (true)
                            {
                                try
                                {
                                    Console.WriteLine("Введите 1 или 2 в зависимости от того, какой метод стортировки использовать: ");
                                    int d = int.Parse(Console.ReadLine());


                                    if (d != 1 && d != 2)
                                    {
                                        Console.WriteLine("Такого задания не существует");
                                    }
                                    else
                                    {
                                        switch (d)
                                        {
                                            case 1:

                                                foreach (int i2 in Buble.Bubble_up(Array_1))
                                                {
                                                    Console.Write(i2 + " ");
                                                }
                                                Console.WriteLine();
                                                break;


                                            case 2:
                                                Array.Sort(Array_2);
                                                Array.Reverse(Array_2);
                                                foreach (int i3 in Array_2)
                                                {
                                                    Console.Write(i3 + " ");
                                                }
                                                Console.WriteLine();
                                                break;

                                            default:
                                                break;
                                        }
                                    }

                                    break;
                                }
                                catch
                                {
                                    Console.WriteLine("Error");
                                }


                            }



                        }

                    }
                }
                break;

            }
            catch
            {
                Console.WriteLine("Error");
            }
        }
    }



    virtual protected void task2()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Введите <b>, если хотите осуществить ввод через консоль или <k>, если через файл: ");
                string n = "";
                n = Console.ReadLine();

                if (n != "b" && n != "k")
                {
                    Console.WriteLine("Такой команды не существует");
                }
                else
                {
                    if (n == "b")
                    {
                        Console.Write("Ведите количество строк: ");
                        int x = int.Parse(Console.ReadLine());
                        Console.Write("Ведите количество столбцов: ");
                        int y = int.Parse(Console.ReadLine());
                        int[,] Array_3 = new int[x, y];

                        Console.WriteLine("Введите массив: ");

                        for (int i2 = 0; i2 < x; i2++)
                        {
                            var t = Console.ReadLine().Split();

                            for (int j2 = 0; j2 < y; j2++)
                            {
                                Array_3[i2, j2] = int.Parse(t[j2]);
                            }
                        }

                        for (int i3 = 0; i3 < x; i3++)
                        {
                            for (int j3 = 0; j3 < y; j3++)
                            {
                                Console.Write(Array_3[i3, j3] + "\t");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();


                        int Max1 = Array_3[0, 0];
                        int Min1 = Array_3[0, 0];
                        int indexmax = 0;
                        int indexmin = 0;
                        for (int i4 = 0; i4 < Array_3.GetLength(0); i4++)
                        {
                            for (int j4 = 0; j4 < Array_3.GetLength(1); j4++)
                            {
                                if (Array_3[i4, j4] > Max1)
                                {
                                    indexmax = i4;
                                    indexmin = j4;
                                    Max1 = Array_3[i4, j4];
                                }
                            }

                        }

                        int indexmax1 = 0;
                        int indexmin1 = 0;

                        for (int i5 = 0; i5 < Array_3.GetLength(0); i5++)
                        {

                            for (int j5 = 0; j5 < Array_3.GetLength(1); j5++)
                            {
                                if (Array_3[i5, j5] < Min1)
                                {
                                    indexmax1 = i5;
                                    indexmin1 = j5;
                                    Min1 = Array_3[i5, j5];
                                }
                            }

                        }

                        Console.WriteLine($"Максимальное значение стоит под индексом: [{indexmax};{indexmin}] и равен: {Max1}");
                        Console.WriteLine($"Минимальное значение стоит под индексом: [{indexmax1};{indexmin1}] и равен: {Min1}");

                    }
                    if (n == "k")
                    {
                        Console.Write("Введите количество строк: ");
                        int x = int.Parse(Console.ReadLine());
                        Console.Write("Введите количество столбцов: ");
                        int y = int.Parse(Console.ReadLine());

                        Console.WriteLine("Введите путь к этому файлу с указанием типа файла(.txt) ");
                        using var sr = new StreamReader(Console.ReadLine());


                        var w = sr.ReadLine();

                        int[,] Array_3 = new int[x, y];

                        for (int i2 = 0; i2 < x; i2++)
                        {
                            var t = sr.ReadLine().Split();

                            for (int j2 = 0; j2 < y; j2++)
                            {
                                Array_3[i2, j2] = int.Parse(t[j2]);
                            }
                        }

                        for (int i3 = 0; i3 < x; i3++)
                        {
                            for (int j3 = 0; j3 < y; j3++)
                            {
                                Console.Write(Array_3[i3, j3] + "\t");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();


                        int Max1 = Array_3[0, 0];
                        int Min1 = Array_3[0, 0];

                        for (int i4 = 0; i4 < Array_3.GetLength(0); i4++)
                        {
                            for (int j4 = 0; j4 < Array_3.GetLength(1); j4++)
                            {
                                if (Array_3[i4, j4] > Max1)
                                {
                                    Max1 = Array_3[i4, j4];
                                }
                            }

                        }

                        for (int i5 = 0; i5 < Array_3.GetLength(0); i5++)
                        {

                            for (int j5 = 0; j5 < Array_3.GetLength(1); j5++)
                            {
                                if (Array_3[i5, j5] < Min1)
                                {
                                    Min1 = Array_3[i5, j5];
                                }
                            }

                        }

                        Console.WriteLine(Max1);
                        Console.WriteLine(Min1);

                    }

                }
                Console.WriteLine();

                break;
            }
            catch
            {
                Console.WriteLine("Error");
            }

        }

    }






    virtual protected void task3()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Введите <b>, если хотите осуществить ввод через консоль или <k>, если через файл: ");
                string n = "";
                n = Console.ReadLine();

                if (n != "b" && n != "k")
                {
                    Console.WriteLine("Такой команды не существует");
                }
                else
                {
                    if (n == "b")
                    {
                        Console.Write("Введите количество строк: ");
                        int x1 = int.Parse(Console.ReadLine());

                        Console.Write("Введите первый индекс: ");
                        int x2 = int.Parse(Console.ReadLine());
                        Console.Write("Введите второй индекс: ");
                        int y2 = int.Parse(Console.ReadLine());


                        int[][] Array_4 = new int[x1][];

                        for (int i5 = 0; i5 < x1; i5++)
                        {
                            var t1 = Console.ReadLine().Trim().Split();

                            for (int j5 = 0; j5 < t1.Length; j5++)
                            {
                                Array.Resize(ref Array_4[i5], j5 + 1);
                                Array_4[i5][j5] = int.Parse(t1[j5]);
                            }
                        }

                        int Max2 = Array_4[0][0];
                        int Min2 = Array_4[0][0];

                        for (int i7 = 0; i7 < Array_4.Length; i7++)
                        {
                            for (int j7 = 0; j7 < Array_4[i7].Length; j7++)
                            {
                                if (Array_4[i7][j7] > Max2)
                                {
                                    Max2 = Array_4[i7][j7];
                                }
                            }

                        }

                        for (int i8 = 0; i8 < Array_4.Length; i8++)
                        {
                            for (int j8 = 0; j8 < Array_4[i8].Length; j8++)
                            {
                                if (Array_4[i8][j8] < Min2)
                                {
                                    Min2 = Array_4[i8][j8];
                                }
                            }

                        }

                        Array_4[x2][y2] = new Random().Next(100);
                        for (int i6 = 0; i6 < x1; i6++)
                        {
                            for (int j6 = 0; j6 < Array_4[i6].Length; j6++)
                            {

                                Console.Write(Array_4[i6][j6] + "\t");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();

                        Console.WriteLine(Max2);
                        Console.WriteLine(Min2);


                    }

                }
                if (n == "k")
                {
                    Console.Write("Введите количество строк: ");
                    int x1 = int.Parse(Console.ReadLine());

                    Console.Write("Введите первый индекс: ");
                    int x2 = int.Parse(Console.ReadLine());
                    Console.Write("Введите второй индекс: ");
                    int y2 = int.Parse(Console.ReadLine());

                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Введите путь к этому файлу с указанием типа файла(.txt) ");
                            using var sr = new StreamReader(Console.ReadLine());


                            int[][] Array_4 = new int[x1][];

                            for (int i5 = 0; i5 < x1; i5++)
                            {
                                var t1 = sr.ReadLine().Trim().Split();

                                for (int j5 = 0; j5 < t1.Length; j5++)
                                {
                                    Array.Resize(ref Array_4[i5], j5 + 1);
                                    Array_4[i5][j5] = int.Parse(t1[j5]);
                                }
                            }

                            int Max2 = Array_4[0][0];
                            int Min2 = Array_4[0][0];

                            for (int i7 = 0; i7 < Array_4.Length; i7++)
                            {
                                for (int j7 = 0; j7 < Array_4[i7].Length; j7++)
                                {
                                    if (Array_4[i7][j7] > Max2)
                                    {
                                        Max2 = Array_4[i7][j7];
                                    }
                                }

                            }

                            for (int i8 = 0; i8 < Array_4.Length; i8++)
                            {
                                for (int j8 = 0; j8 < Array_4[i8].Length; j8++)
                                {
                                    if (Array_4[i8][j8] < Min2)
                                    {
                                        Min2 = Array_4[i8][j8];
                                    }
                                }

                            }

                            Array_4[x2][y2] = new Random().Next(100);
                            for (int i6 = 0; i6 < x1; i6++)
                            {
                                for (int j6 = 0; j6 < Array_4[i6].Length; j6++)
                                {

                                    Console.Write(Array_4[i6][j6] + "\t");
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine();

                            Console.WriteLine(Max2);
                            Console.WriteLine(Min2);
                            Console.WriteLine();
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Error");
                        }




                    }



                }
                Console.WriteLine();
                break;

            }
            catch
            {
                Console.WriteLine("Error");
            }



        }



    }

    class Buble
    {
        internal static object Bubble_up()
        {
            throw new NotImplementedException();
        }

        public static int[] Bubble_up(int[] Array_1)
        {
            int perm;
            for (int i1 = 0; i1 < Array_1.Length; i1++)
            {
                for (int j1 = i1 + 1; j1 < Array_1.Length; j1++)
                {
                    if (Array_1[i1] > Array_1[j1])
                    {
                        perm = Array_1[i1];
                        Array_1[i1] = Array_1[j1];
                        Array_1[j1] = perm;
                    }
                }
            }
            return Array_1;
        }
    }
}
