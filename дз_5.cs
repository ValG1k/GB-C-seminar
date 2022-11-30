void FillArray(int[] nums)
{
    Random rand = new Random();
    int size = nums.Length;
    for (int i = 0; i < size; i++)
    {
        nums[i] = rand.Next(100, 1000);
    }
}

void PrintArray(int[] nums)
{
    int size = nums.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(nums[i] + "   ");
    }
    Console.WriteLine();
}



//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

void Zadacha34()
{


    int[] numbers = new int[10];

    FillArray(numbers);
    Console.WriteLine("Вывод рандомного массива: ");
    PrintArray(numbers);

    Console.WriteLine("Массив четных чисел: ");
    int counter = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            Console.Write(numbers[i] + " ");
            counter++;
        }

    }
    Console.WriteLine();
    Console.WriteLine($"Четных чисел в массиве: {counter}");
}

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.
void Zadacha36()
{
    int[] numbers = new int[10];

    FillArray(numbers);
    Console.WriteLine("Вывод рандомного массива: ");
    PrintArray(numbers);

    int sum = 0;
    Console.WriteLine("Массив элементов с нечётными индексами: ");

    for (int i = 0; i < numbers.Length; i++)
    {
        if (i % 2 != 0)
        {
            Console.Write(numbers[i] + "=" + i + " ");
            sum += numbers[i];

        }

    }
    Console.WriteLine();
    Console.WriteLine($"Сумма элементов с нечётными индексами = {sum}");

}

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива
void Zadacha38()
{
    double[] numbers = new double[10];

    FillArray_double(numbers);
    Console.WriteLine("Вывод рандомного массива: ");
    PrintArray_double(numbers);

    double max = numbers[0];
    double min = numbers[0];

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
        else if (numbers[i] < min)
        {
            min = numbers[i];
        }
    }
    Console.WriteLine($"Минимальное число: {min}");
    Console.WriteLine($"Максимальное число: {max}");
    Console.WriteLine($"Разница между максимальным и минимальным числами: {max - min}");
}

void FillArray_double(double[] nums)
{
    Random rand = new Random();
    int size = nums.Length;
    for (int i = 0; i < size; i++)
    {
        nums[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
    }

}

void PrintArray_double(double[] nums)
{
    int size = nums.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(nums[i] + " ");
    }
    Console.WriteLine();
}


Zadacha34();
Zadacha36();
Zadacha38();