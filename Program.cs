//Задача 2

Console.WriteLine("Введи первое число");
int numberFirst = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введи второе число");
int numberSecond = Convert.ToInt32(Console.ReadLine());


if (numberFirst > numberSecond)
{
    Console.WriteLine($"{numberFirst} больше {numberSecond}");
}
else
{
    Console.WriteLine($"{numberFirst} меньше {numberSecond}");
}


//Задача 4

Console.WriteLine("Введи первое число");
int numberFirst = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введи второе число");
int numberSecond = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введи третье число");
int numbeThird = Convert.ToInt32(Console.ReadLine());

int max = numberFirst;

if (numberSecond > numberFirst)
{
    max = numberSecond;
}
if (numbeThird > max)
{
    max = numbeThird;
}

Console.WriteLine ("максмальное число " + max);


//Задача 6

Console.WriteLine("Введи  число");
int number = Convert.ToInt32(Console.ReadLine());

if (number %2 == 0)
{
    Console.WriteLine (number + " Четное число");
} 
else
{
    Console.WriteLine (number + " Нечетное число");
}


//Задача 8
Console.WriteLine("Введи  число");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i <= number)
{
   if (i % 2 == 0) 
   {
        Console.Write(i + " ");
   }
   i++; 
}

