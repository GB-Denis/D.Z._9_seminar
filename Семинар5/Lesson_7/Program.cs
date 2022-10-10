// 
// void Zadacha46()
// {
//     // Задайте двумерный массив размером m*n
//     // заполненный случайными числами.
//     Console.WriteLine("Введите число строк массива");
//     int m = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите число столбцов массива");
//     int n = Convert.ToInt32(Console.ReadLine());
//     int rows = m;
//     int columns = n;
//     int[,] numbers = new int[rows, columns];
//     FillArray(numbers);
//     PrintArray(numbers);
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
// Zadacha46();




// void Zadacha48()
// {
//     // Задайте двумерный массив размером m*n, каждый элемент в массиве
//     // находится по формуле: A= i+j. Выведите полученный массив на экран.
//     Console.WriteLine("Введите число строк массива");
//     int m = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите число столбцов массива");
//     int n = Convert.ToInt32(Console.ReadLine());
//     int rows = m;
//     int columns = n;
//     int[,] numbers = new int[rows, columns];
//     FillArray(numbers);
//     PrintArray(numbers);
// }
// void FillArray(int[,] numbers)
// {
//     int rows = numbers.GetLength(0);
//     int columns = numbers.GetLength(1);
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             numbers[i, j] = i + j;
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
// Zadacha48();




// void Zadacha49()
// {
//     // Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
//     // и замените эти элементы на их квадраты.
//     Console.WriteLine("Введите число строк массива");
//     int m = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите число столбцов массива");
//     int n = Convert.ToInt32(Console.ReadLine());
//     int rows = m;
//     int columns = n;
//     int[,] numbers = new int[rows, columns];
//     FillArray(numbers);
//     PrintArray(numbers);
//     Summ(numbers);
//     Console.WriteLine();
//     PrintArray(numbers);
// }
// void Summ(int[,] numbers)
// {
//     int rows = numbers.GetLength(0);
//     int columns = numbers.GetLength(1);
//     for (int i = 0; i < rows; i += 2)
//     {
//         for (int j = 0; j < columns; j += 2)
//         {
//             numbers[i, j] = numbers[i, j] * numbers[i, j];
//         }
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
//             numbers[i, j] = random.Next(0, 10);
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
// Zadacha49();




// void Zadacha49()
// {
//     // Задайте двумерный массив. Найдите сумму элементов, находящихся на 
//     // главной диагонали(с индексами 0,0); (1;1) и т.д.
//     Console.WriteLine("Введите число строк массива");
//     int m = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите число столбцов массива");
//     int n = Convert.ToInt32(Console.ReadLine());
//     int rows = m;
//     int columns = n;
//     int[,] numbers = new int[rows, columns];
//     FillArray(numbers);
//     PrintArray(numbers);
//     Console.WriteLine();
//     ChekingArray(numbers);
// }
// void ChekingArray(int[,] numbers)
// {
//     int summ = 0;
//     int rows = numbers.GetLength(0);
//     int columns = numbers.GetLength(1);
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             if (i == j)
//             {
//                 summ = summ + numbers[i, j];
//                 Console.Write($"{numbers[i, j]}  ");
//             }
//         }
//     }
//     Console.WriteLine($"Сумма элементов, находящихся на главной диагонали = {summ}");
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
//             numbers[i, j] = random.Next(0, 10);
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
// Zadacha49();




void ZadachaFootbal()
{
    // Дан двумерный массив из 2 строк и 22 столбцов. В 1 строке количество забитых мячей.
    // Во 2-ой строке количество пропущенных мячей в этой же игре.
    // a) Для каждой игры напечать словесный результат. выигрыш ничья или проигрыш.
    // b) Определить сколько раз выиграла данная команда.
    // c) Определить сколько раз выиграла и проиграла данная команда
    // d) Определить сколько раз выиграла, сколько ничьих, и сколько раз проиграла  данная команда
    // e) Определить в скольких играх разность забитых и пропущенных мячей была большей или равна 3.
    // f) Определить общее количество очков, набранных командой(выигрыш 3 очка, ничья 1 очко, проигрыш 0 очков).
    int rows = 2;
    int columns = 10;
    int[,] numbers = new int[rows, columns];
    FillArray(numbers, 0, 10);
    PrintArray(numbers);
    Console.WriteLine();
    GamesA(numbers);
    GamesBCD(numbers);
    GamesE(numbers);
    GamesF(numbers); 
}
void FillArray(int[,] numbers, int minBalls = 0, int maxBalls = 1)
{
    maxBalls++;
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(minBalls, maxBalls);
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
            Console.Write(numbers[i, j] + "  ");
        }
        Console.WriteLine();
    }
}
void GamesA(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < columns; i++)
    {
        if (numbers[0, i] > numbers[1, i])
        {
            Console.WriteLine($" win {numbers[0, i]}:{numbers[1, i]} ");
        }
        if (numbers[0, i] < numbers[1, i])
        {
            Console.WriteLine($" lose {numbers[0, i]}:{numbers[1, i]} ");
        }
        if (numbers[0, i] == numbers[1, i])
        {
            Console.WriteLine($" draw {numbers[0, i]}:{numbers[1, i]} ");
        }
    }
}
void GamesBCD(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    int win = 0;
    int lose = 0;
    int draw = 0;
    for (int i = 0; i < columns; i++)
    {
        if (numbers[0, i] > numbers[1, i])
        {
            win++;
        }
        if (numbers[0, i] < numbers[1, i])
        {
            lose++;
        }
        if (numbers[0, i] == numbers[1, i])
        {
            draw++;
        }
    }
    Console.WriteLine("Количество побед:" + win);
    Console.WriteLine("Количество поражений:" + lose);
    Console.WriteLine("Количество ничьих:" + draw);
}
void GamesE(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    int sum = 0;
    for (int i = 0; i < columns; i++)
    {
        if (numbers[0, i] - numbers[1, i] >=3)
        {
            sum++;
        }
    }
    Console.WriteLine($"В {sum} матчах разность забитых и пропущенных мячей была большей или равна 3");
}
void GamesF(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    int win = 0;
    int lose = 0;
    int draw = 0;
    int points = 0;
    for (int i = 0; i < columns; i++)
    {
        if (numbers[0, i] > numbers[1, i])
        {
            win++;
        }
        if (numbers[0, i] < numbers[1, i])
        {
            lose++;
        }
        if (numbers[0, i] == numbers[1, i])
        {
            draw++;
        }
    }
    points = win * 3 + draw;
    Console.WriteLine("Общее количество очков команды:" + points);
}
ZadachaFootbal();

