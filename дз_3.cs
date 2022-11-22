void Zadacha19()
{
    //Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

    Console.WriteLine("Введите положительное пятизначное число: ");
    string number = Console.ReadLine();

    if (number.Length == 5)
    {
        if (number[0] == number[4] && number[1] == number[3])
        {
            Console.WriteLine("Введенное число " + number + " является палиндромом");
        }
        else Console.WriteLine("Введенное число " + number + " не является палиндромом");
    }
    else Console.WriteLine("ОШИБКА! Вводите положительное пятизначное число!");
}

void Zadacha21()
{
    //Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

    Console.Write("Введите координату X первой точки: ");
    int x1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату Y первой точки: ");
    int y1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату Z первой точки: ");
    int z1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите координату X второй точки: ");
    int x2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату Y второй точки: ");
    int y2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату Z второй точки: ");
    int z2 = Convert.ToInt32(Console.ReadLine());

    //AB = √(xb - xa)^2 + (yb - ya)^2 + (zb - za)^2
    double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    
    Console.WriteLine($"Расстояние между точками {Math.Round(distance,2)}");
}

void Zadacha23()
{
    //Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
    
    Console.WriteLine("Введите число: ");
    
    int number = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i <= number; i++)
    {
        Console.WriteLine(Math.Pow(i,3));
    }

}


Zadacha19();
Zadacha21();
Zadacha23();
