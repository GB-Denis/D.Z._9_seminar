// // 
void Zadacha54()
{
    // Задайте двумерный массив. Напишите программу, которая упорядочит по 
    // убыванию элементы каждой строки двумерного массива.
    Console.WriteLine("Введите число строк массива");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число столбцов массива");
    int n = Convert.ToInt32(Console.ReadLine());
    int rows = m;
    int columns = n;
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);
    OrderArray(numbers, rows, columns);
    Console.WriteLine("Сортировка строк по убыванию->");
    PrintArray(numbers);
}
void OrderArray(int[,] numbers, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < columns - 1; k++)
            {
                if (numbers[i, k] < numbers[i, k + 1])
                {
                    int temp = numbers[i, k + 1];
                    numbers[i, k + 1] = numbers[i, k];
                    numbers[i,k] = temp;
                }

            }
        }
    }  
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
void PrintArray(int[,] numbers)
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
Zadacha54();


void Zadacha56()
{
    // Задайте прямоугольный двумерный массив. Напишите программу,
    // которая будет находить строку с наименьшей суммой элементов.
    Console.WriteLine("Введите число строк массива");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число столбцов массива");
    int n = Convert.ToInt32(Console.ReadLine());
    int rows = m;
    int columns = n;
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);

int minSumLine = 0;
int sumLine = SumLineElements(numbers, 0);
for (int i = 1; i < numbers.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(numbers, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}
Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");
int SumLineElements(int[,] numbers, int i)
{
  int sumLine = numbers[i,0];
  for (int j = 1; j < numbers.GetLength(1); j++)
  {
    sumLine += numbers[i,j];
  }
  return sumLine;
}
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
void PrintArray(int[,] numbers)
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
Zadacha56();



void Zadacha58()
{
    // Напишите программу, которая заполнит спирально массив 4 на 4.
    Console.WriteLine("Введите число строк и столбцов массива");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] sqareMatrix = new int[n, n];
    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
    {
        sqareMatrix[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    PrintArray(sqareMatrix);
}
void PrintArray(int[,] numbers)
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
Zadacha58();



