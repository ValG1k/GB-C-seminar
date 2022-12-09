
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void FillArray_double(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 100;
        }
    }

}

void PrintArray_double(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(array[i, j], 1)}\t");
        }
        Console.WriteLine();
    }
}

//  Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.

void Zadacha47()
{

    Console.WriteLine("Введите количество строк");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите количество столбцов");
    int colums = Convert.ToInt32(Console.ReadLine());

    double[,] numbers = new double[rows, colums];
    FillArray_double(numbers);
    PrintArray_double(numbers);

}

//Задача 50. Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, 
//           и возвращает значение этого элемента или же указание, что такого элемента нет.

void Zadacha50()
{
    Console.WriteLine("Введите номер строки");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите номер столбца");
    int m = Convert.ToInt32(Console.ReadLine());

    int[,] numbers = new int[10, 10];
    FillArray(numbers);

    if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
    {
        Console.WriteLine("Такого элемента нет");
    }
    else
    {
        Console.WriteLine($"Значение элемента {n} строки и {m} столбца равно {numbers[n - 1, m - 1]}");
    }


    PrintArray(numbers);
}

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void Zadacha52()
{
    Console.WriteLine("Введите количество строк");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите количество столбцов");
    int m = Convert.ToInt32(Console.ReadLine());

    int[,] numbers = new int[n, m];
    FillArray(numbers);

    Console.WriteLine();
    PrintArray(numbers);
    Console.WriteLine("Среднее арифметическое значение каждого столбца:");

    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        double avarage = 0;
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            avarage = (avarage + numbers[i, j]);
        }
        avarage = avarage / n;
        Console.Write($"{Math.Round(avarage,2)}\t");
    }

}

Zadacha47();
Zadacha50();
Zadacha52();
