namespace дз_8;
class Program
{
    static void Main(string[] args)
    {
        //Задача 54. Задайте двумерный массив. Напишите программу, 
        //которая упорядочит по убыванию элементы каждой строки двумерного массива.
        void Zadacha54()
        {
            Console.WriteLine("Введите количество строк");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] numbers = new int[rows, columns];
            FillArray(numbers, 1, 20);
            PrintArray(numbers);

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1) - 1; j++)
                {
                    for (int k = 0; k < numbers.GetLength(1) - 1; k++)
                    {
                        if (numbers[i, k] < numbers[i, k + 1])
                        {
                            int temp = 0;
                            temp = numbers[i, k];
                            numbers[i, k] = numbers[i, k + 1];
                            numbers[i, k + 1] = temp;
                        }
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Массив с упорядоченными значениями");
            PrintArray(numbers);

        }

        //Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, 
        //которая будет находить строку с наименьшей суммой элементов.

        void Zadacha56()
        {
            Console.WriteLine("Введите количество строк");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] numbers = new int[rows, columns];
            FillArray(numbers, 1, 20);
            PrintArray(numbers);
            int minsum = Int32.MaxValue;
            int indexLine = 0;

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    sum = sum + numbers[i, j];
                }
                if (sum < minsum)
                {
                    minsum = sum;
                    indexLine++;
                }
            }

            Console.WriteLine("строка с наименьшей суммой елементов под номером: " + (indexLine) + ", с суммой елементов равной: " + (minsum));
        }

        //Задача 58. Заполните спирально массив 4 на 4 числами от 1 до 16.
        void Zadacha58()
        {
            int n = 4;
            int[,] array = new int[n, n];

            int temp = 1;
            int i = 0;
            int j = 0;

            while (temp <= array.GetLength(0) * array.GetLength(1))
            {
                array[i, j] = temp;
                temp++;
                if (i <= j + 1 && i + j < array.GetLength(1) - 1)
                    j++;
                else if (i < j && i + j >= array.GetLength(0) - 1)
                    i++;
                else if (i >= j && i + j > array.GetLength(1) - 1)
                    j--;
                else
                    i--;
            }

            PrintArray(array);
        }

        Zadacha54();
        Zadacha56();
        Zadacha58();
    }

    static void FillArray(int[,] numbers, int minValue, int maxValue)
    {
        maxValue++;
        Random rand = new Random();
        int rows = numbers.GetLength(0);
        int colums = numbers.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            {
                numbers[i, j] = rand.Next(minValue, maxValue);
            }
        }
    }

    static void PrintArray(int[,] numbers, string message = "Вывод массива:")
    {
        int rows = numbers.GetLength(0);
        int colums = numbers.GetLength(1);
        Console.WriteLine(message);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            {
                Console.Write($"{numbers[i, j]}\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
