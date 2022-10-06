// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
void Zadacha_34()
{
    Random random = new Random();
    int size = random.Next(100, 1000);
    int[] numbers = new int[10];
    FillArray(numbers, 100, 1000);
    PrintArray(numbers);
    CheckingEven(numbers);
}
Zadacha_34();
void FillArray(int[] numbers, int minValue = 100, int maxValue = 1000)
{
    maxValue++;
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(100, 1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.WriteLine("Вывод массива:");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}
void CheckingEven(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Количество чётных чисел в массиве. {count} ");
}



// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.
void Zadacha_36()
{   
    Random random = new Random();
    int size = random.Next(10, 100);
    int[] numbers = new int[6];
    FillArray(numbers, 10, 100);
    PrintArray(numbers);
    CheckingSummOdd(numbers);
}
Zadacha_36();
void FillArray(int[] numbers, int minValue = 10, int maxValue = 100)
{
    maxValue++;
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(10, 100);
    }
}
void PrintArray(int[] numbers)
{
    Console.WriteLine("Вывод массива:");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}
void CheckingSummOdd(int[] numbers)
{
    int summ = 0;
    for (int i = 0; i < numbers.Length; i+=2)
    {
            summ = numbers[i] + summ;
    }
    Console.WriteLine($"Cумма элементов с нечётными индексами {summ} ");
}



// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
void Zadacha_38()
{
    Random random = new Random();
    int size = random.Next(-50, 100);
    double[] numbers = new double[5];
    FillArray(numbers, 10, 100);
    PrintArray(numbers);
    CheckingDiff(numbers);
}
Zadacha_38();
void FillArray(double[] numbers, int minValue = -50, int maxValue = 100)
{
    maxValue++;
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(new Random().Next(-5000,10000)) / 100;
    }
}
void PrintArray(double[] numbers)
{
    Console.WriteLine("Вывод массива:");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " |");
    }
    Console.WriteLine();
}
void CheckingDiff(double[] numbers)
{
    double min = Int32.MaxValue;
    double max = Int32.MinValue;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
    }
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] <= min)
        {
            min = numbers[i];
        }
        else i++;
        // Console.WriteLine($"{numbers[i]} {min}");
    }
    Console.WriteLine($"Максимальный элемент в массиве {max} , минимальный элемент в массиве {min}.");
    Console.WriteLine($"Разница между ними {max - min}");
}
