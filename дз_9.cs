namespace дз_9;
class Program
{
    static void Main(string[] args)
    {
        //Задача 64: Задайте значения M и N. Напишите рекурсивный метод, 
        //который выведет все натуральные числа кратные 3-ём в промежутке от M до N.

        void Zadacha64()
        {

            int n = 30;
            int count = 4;
            PrintNumber(n, count);


            void PrintNumber(int n, int count)
            {
                if (count > n) return;

                PrintNumber(n, count + 1);
                if (count % 3 == 0)
                {
                    Console.Write(count + "\t");
                }

            }

        }

        //Задача 66: Задайте значения M и N. Напишите рекурсивный метод, который найдёт сумму натуральных элементов в промежутке от M до N.
        void Zadacha66()
        {
            int m = InputInt("Введите M:");
            int n = InputInt("Введите N:");
            Console.WriteLine($"Сумма элементов от {m} до {n} = {CountNaturalSum(m, n)}");

            int InputInt(string output)
            {
                Console.Write(output);
                return int.Parse(Console.ReadLine());
            }

            int CountNaturalSum(int m, int n)
            {
                if (m == n)
                    return n;
                return n + CountNaturalSum(m, n - 1);
            }
        }

        //Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
        void Zadacha68()
        {
            int m = InputInt("Введите M: ");
            int n = InputInt("Введите N: ");
            Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");

            int InputInt(string output)
            {
                Console.Write(output);
                return int.Parse(Console.ReadLine());
            }

            int Akkerman(int m, int n)
            {
                if (m == 0)
                    return n + 1;
                if (m > 0 && n == 0)
                    return Akkerman(m - 1, 1);
                else
                    return Akkerman(m - 1, Akkerman(m, n - 1));
            }
        }

        Zadacha64();
        Zadacha66();
        Zadacha68();
    }
}
