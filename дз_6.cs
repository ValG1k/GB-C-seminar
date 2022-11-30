
//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
void Zadacha41()
{
    Console.Write("Введите желаемый размер массива: ");
    int size = int.Parse(Console.ReadLine());

    int[] array = new int[size];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1} число ");
        array[i] = int.Parse(Console.ReadLine());
        if (array[i] > 0) count++;
    }

    Console.WriteLine("Твой массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }

    Console.WriteLine();
    Console.WriteLine("Количество чисел больше 0 = " + count);

}

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Zadacha43()
{
    Console.Write("Введите b1: ");
    double b1 = double.Parse(Console.ReadLine());

    Console.Write("Введите k1: ");
    double k1 = double.Parse(Console.ReadLine());

    Console.Write("Введите b2: ");
    double b2 = double.Parse(Console.ReadLine());
    
    Console.Write("Введите k2: ");
    double k2 = double.Parse(Console.ReadLine());



    double x = (b1 - b2) / (k2 - k1);
    double y = (k2 * x + b2);
    Console.WriteLine($"Точка пересечения двух прямых: ({x};{y})");
}

Zadacha41();
Zadacha43();

