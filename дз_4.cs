void Zadacha25()
{
    //Задача 25: Используя определение степени числа, напишите цикл, который принимает на вход 
    //два натуральных числа (A и B) и возводит число A в степень B.

    Console.WriteLine("Введите число A");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите число B");
    int b = Convert.ToInt32(Console.ReadLine());

    int x = a;

    for (int i = 1; i < b; i++)
    {
        x *= a;
    }

    Console.WriteLine("A в степени B = " + x);
}


void Zadacha27()
{
    //Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int sum = 0;

    while (number > 0)
    {
        int j = number % 10;
        number = number / 10;
        sum += j;
    }
    Console.WriteLine("Сумма цифр в числе равна: " + sum);

}

void FillArray(int[] nums)
{
    Random rand = new Random();
    int size = nums.Length;
    for (int i = 0; i < size; i++)
    {
        nums[i] = rand.Next(-10, 10);
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

void Zadacha29()
{
    //Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.

    int size = 8;

    int[] numbers = new int[size];

    FillArray(numbers);
    Console.WriteLine("Вывод рандомного массива: ");
    PrintArray(numbers);
    int temp;

    for (int i = 0; i < numbers.Length - 1; i++)
    {
        for (int j = i + 1; j < numbers.Length; j++)
        {
            if (Math.Abs(numbers[i]) > Math.Abs(numbers[j]))
            {
                temp = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = temp;
            }
        }
    }
    Console.WriteLine("Вывод отсортированного по модулю массива: ");
    PrintArray(numbers);

}


Zadacha25();
Zadacha27();
Zadacha29();