void Zadacha10()
{
    //Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

    Console.WriteLine("Введите трехзначное число: ");
    int numberA = Convert.ToInt32(Console.ReadLine());

    numberA = numberA / 10;
    numberA = numberA % 10;
    Console.WriteLine("Вторая цифра числа -> " + numberA);
}
Zadacha10();

void Zadacha13()
{
    //Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

    Console.WriteLine("Введите число: ");
    string numberA = Console.ReadLine();
    if (numberA.Length > 2)
    {
        Console.WriteLine("третья цифра " + numberA[2]);
    }
    else
    {
        Console.WriteLine("третьей цифры нет");
    }
}
Zadacha13();

void Zadacha15()
{
    //Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

    string[] day = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
    Console.WriteLine("Введите цифру дня недели: ");
    int numberA = Convert.ToInt32(Console.ReadLine());

    if (numberA == 6 || numberA == 7)
    {
        Console.WriteLine($"{day[numberA - 1]} -> Выходной");
    }
    else if (numberA < 1 || numberA > 7)
    {
        Console.WriteLine("Данный номер отсутствует используй числа (1-7)!");
    }
    else Console.WriteLine($"{day[numberA - 1]} -> Рабочий день");

}
Zadacha15();
