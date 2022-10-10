// 
void Zadacha47()
{
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.
    Console.WriteLine("Введите число строк массива");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число столбцов массива");
    int n = Convert.ToInt32(Console.ReadLine());
    int rows = m;
    int columns = n;
    double[,] numbers = new double[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);
}
void FillArray(double[,] numbers)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}
void PrintArray(double[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
Zadacha47();




void Zadacha50()
{
// Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
    Console.WriteLine("Укажите нужную строку в массиве");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Укажите нужный столбцец в массиве");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] numbers = new int[6,6];
    FillArray(numbers);
    PrintArray(numbers);
    CheckingArray(numbers, m, n);
}
void FillArray(int[,] numbers)
{
    Random random = new Random();
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(0); j++)
        {
            numbers[i, j] = random.Next(0, 10);
        }
    }
}
void CheckingArray(int [,] numbers, int m, int n)
{
    if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine($"Строка {m} столбец {n} - такого элемента нет");
}
else
{
    Console.WriteLine($"Значение {m} строки и {n} столбца = {numbers[m-1,n-1]}");
}
}
void PrintArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();
    }


}
Zadacha50();




void Zadacha52()
{
    // Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
    Console.WriteLine("Введите число строк массива");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число столбцов массива");
    int n = Convert.ToInt32(Console.ReadLine());
    int rows = m;
    int columns = n;
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);
    CheckingAverage(numbers);
    
}
void FillArray(int[,] numbers)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(0, 10);
        }
    }
}
void CheckingAverage(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int j = 0; j < columns; j++)
    {
        double avarage = 0;
        for (int i = 0; i < rows; i++)
        {
            avarage = (avarage + numbers[i, j]);
        }

        avarage = avarage / rows;
        Console.Write(avarage + "; ");
    }
}
void PrintArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write( + numbers[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine("Средние арифметические столбцов:");
}
Zadacha52();