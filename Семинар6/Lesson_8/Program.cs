
// //
// void Zadacha53()
// {
//     // Задайте двумерный массив. Напишите программу, 
//     // которая поменяет местами первую и последнюю строку массива.
//     Console.WriteLine("Введите число строк массива");
//     int m = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите число столбцов массива");
//     int n = Convert.ToInt32(Console.ReadLine());
//     int rows = m;
//     int columns = n;
//     int[,] numbers = new int[rows, columns];
//     FillArray(numbers);
//     PrintArray(numbers);
//     TransferArray(numbers, rows); 
//     Console.WriteLine("Поменяли местами первую и последнюю строки массива->");  
//     PrintArray(numbers);
// }
// void TransferRowsArray(int[,] numbers, int rows)
// {
//     int maxIndex = rows - 1; 
//     int minIndex = 0;
//     int maxColumns = numbers.GetLength(0);
//     for (int j = 0; j < maxColumns; j++)
//     {
//         (numbers[minIndex,j], numbers[maxIndex,j]) = (numbers[maxIndex,j], numbers[minIndex,j]);
//     }
// }
// void FillArray(int[,] numbers)
// {
//     Random random = new Random();
//     int rows = numbers.GetLength(0);
//     int columns = numbers.GetLength(1);
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             numbers[i, j] = random.Next(-10, 10);
//         }
//     }
// }
// void PrintArray(int[,] numbers)
// {
//     int rows = numbers.GetLength(0);
//     int columns = numbers.GetLength(1);
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             Console.Write(numbers[i, j] + "\t");
//         } 
//         Console.WriteLine();
//     }


// }
// Zadacha53();




// void Zadacha55()
// {
//     // Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//     // В случае, если это невозможно, программа должна вывести сообщение для пользователя.
//     Console.WriteLine("Введите число строк массива");
//     int m = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите число столбцов массива");
//     int n = Convert.ToInt32(Console.ReadLine());
//     int rows = m;
//     int columns = n;
//     int[,] numbers = new int[rows, columns];
//     FillArray(numbers);
//     PrintArray(numbers);
//     TransferArray(numbers);
// }
// void TransferArray(int[,] numbers)
// {
//     if (numbers.GetLength(0) == numbers.GetLength(1))
//     {
//         int i = 0;
//         for (int j = i; j < numbers.GetLength(0); j++)
//         {
//             for (i = j; i < numbers.GetLength(1); i++)
//             {
//                 (numbers[i, j], numbers[j, i]) = (numbers[j, i], numbers[i, j]);
//             }
//         }
//         Console.WriteLine("Поменяли в массиве строки на столбцы->");
//         PrintArray(numbers);
//     }
//     else
//     {
//         Console.WriteLine("Число строк должно соответствовать числу столбцов массива");
//         Console.WriteLine("Введите корректный массив");
//     }
// }
// void FillArray(int[,] numbers)
// {
//     Random random = new Random();
//     int rows = numbers.GetLength(0);
//     int columns = numbers.GetLength(1);
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             numbers[i, j] = random.Next(-10, 10);
//         }
//     }
// }
// void PrintArray(int[,] numbers)
// {
//     int rows = numbers.GetLength(0);
//     int columns = numbers.GetLength(1);
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             Console.Write(numbers[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }
// Zadacha55();




// void Zadacha57()
// {
//     // Составить частотный словарь элементов двумерного массива.
//     // Частотный словарь содержит информацию о том, сколько раз
//     // встерчается элемент входных данных.
//     Console.WriteLine("Введите число строк массива");
//     int m = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите число столбцов массива");
//     int n = Convert.ToInt32(Console.ReadLine());
//     int rows = m;
//     int columns = n;
//     int[,] numbersA = new int[rows, columns];
//     int[] numbersD = new int[10];
//     FillArray(numbersA, numbersD);
//     PrintArray(numbersA, numbersD);
//     DictionaryArray(numbersA, numbersD, rows, columns);

// }
// void DictionaryArray(int[,] numbersA, int[] numbersD, int rows, int columns)
// {
//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < columns; j++)
//         {
//             numbersD[numbersA[i,j]]++;
//         }
//     }
//     for(int i = 0; i < 10; i++)
//     {
//         Console.WriteLine($"Количество {i} в массиве равно {numbersD[i]}");
//     }
// }
// void FillArray(int[,] numbersA, int[] numbersD)
// {
//     Random random = new Random();
//     int rows = numbersA.GetLength(0);
//     int columns = numbersA.GetLength(1);
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             numbersA[i, j] = random.Next(0, 10);
//         }
//     }
// }
// void PrintArray(int[,] numbersA, int[] numbersD)
// {
//     int rows = numbersA.GetLength(0);
//     int columns = numbersA.GetLength(1);
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             Console.Write(numbersA[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }
// Zadacha57();



// void Zadacha59()
// {
//     // Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец,
//     // на пересечении которых расположен наименьший элемент массива.
//     Console.WriteLine("Введите число строк массива");
//     int m = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите число столбцов массива");
//     int n = Convert.ToInt32(Console.ReadLine());
//     int rows = m;
//     int columns = n;
//     int[,] numbersA = new int[rows, columns];
//     FillArray(numbersA);
//     PrintArray(numbersA);
//     DeleteRowsColumnsArray(numbersA, rows, columns);

// }
// void DeleteRowsColumnsArray(int[,] numbersA, int rows, int columns)
// {
//     int min = numbersA[0, 0];
//     int i_min = 0;
//     int j_min = 0;
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             if (numbersA[i, j] < min)
//             {
//                 min = numbersA[i, j];
//                 i_min = i;
//                 j_min = j;
//             }
//         }
//     }
//     Console.WriteLine();
//     Console.WriteLine($"Наименьший элемент на {i_min + 1} строке, в {j_min + 1} колонне  = {min}");

//     int rowsResult = rows - 1;
//     int columnsResult = columns - 1;
//     int[,] result = new int[rowsResult, columnsResult];
//     int biasI = 0;
//     int biasJ = 0;

//     for (int i = 0; i < rowsResult; i++)
//     {
//         if (i == i_min) biasI++;
//         biasJ = 0;
//         for (int j = 0; j < columnsResult; j++)
//         {
//             if (j == j_min) biasJ++;
//             result[i, j] = numbersA[i + biasI, j + biasJ];
//         }
//     }
//     Console.WriteLine();
//     PrintArray(result);
// }
// void FillArray(int[,] numbersA)
// {
//     Random random = new Random();
//     int rows = numbersA.GetLength(0);
//     int columns = numbersA.GetLength(1);
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             numbersA[i, j] = random.Next(-99, 100);
//         }
//     }
// }
// void PrintArray(int[,] numbersA)
// {
//     int rows = numbersA.GetLength(0);
//     int columns = numbersA.GetLength(1);
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             Console.Write(numbersA[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }
// Zadacha59();


// void DopZadacha()
// {
//     Console.WriteLine("Введите число строк массива");
//     int m = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите число столбцов массива");
//     int n = Convert.ToInt32(Console.ReadLine());
//     int rows = m;
//     int columns = n;
//     int[,] numbers = new int[rows, columns];
//     FillArray(numbers);
//     int iMax = rows - 1;
//     int jMax = columns - 1;
//     numbers[0, 0] = 1;
//     numbers[iMax, jMax] = 1;
//     PrintArray(numbers);
//     bool exit = false;
//     FindPath(numbers);

//     if(exit) Console.WriteLine("Выход есть");
//     else Console.WriteLine("Тупик");
//     Console.WriteLine();
//     PrintArray(numbers);



// void FindPath(int[,] numbers, int i = 0, int j = 0)
// // Проверка лабиринта
// {
//     if(i < 0 
//     || i > iMax 
//     || j < 0
//     || j > jMax
//     || numbers[i,j] == 0
//     || numbers[i,j] == 2)
//     {
//         return;
//     }

//     if(i == iMax && j == jMax)
//     {
//         exit = true;
//         return;
//     }
//     numbers[i,j] = 2;
//     FindPath(numbers, i + 1, j);
//     FindPath(numbers, i - 1, j);
//     FindPath(numbers, i, j + 1);
//     FindPath(numbers, i, j - 1);

// }
// }
// void FillArray(int[,] numbers)
// {
//     Random random = new Random();
//     int rows = numbers.GetLength(0);
//     int columns = numbers.GetLength(1);
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             numbers[i, j] = random.Next(0, 2);
//         }
//     }
// }
// void PrintArray(int[,] numbers)
// {
//     int rows = numbers.GetLength(0);
//     int columns = numbers.GetLength(1);
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             Console.Write(numbers[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }
// DopZadacha();

void Kursor()
{
    int x = 0;
    int y = 0;
    string player = "@";
    bool isPlaying = true;

    while (isPlaying)
    {
        Console.Clear();
        Console.SetCursorPosition(x, y);
        Console.Write(player);
        ConsoleKeyInfo keyInfo = Console.ReadKey();
        Console.CursorVisible = false;
        if (keyInfo.Key == ConsoleKey.DownArrow)
        {
            y++;
        }
        if (keyInfo.Key == ConsoleKey.UpArrow)
        {
            y--;
        }
        if (keyInfo.Key == ConsoleKey.LeftArrow)
        {
            x--;
        }
        if (keyInfo.Key == ConsoleKey.RightArrow)
        {
            x++;
        }
        if(keyInfo.Key == ConsoleKey.E)
        {
            isPlaying = false;
            Console.Clear();
            Console.WriteLine("Спасибо за игру");
        }
        Console.ReadKey();

    }
}
Kursor();