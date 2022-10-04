// // Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]
// // Найдите сумму отриательных и положительных элементов массива.
// void Zadacha_31()
// {
//     int size = 12;
//     int[] numbers = new int[size];
//     FillArray(numbers, -9, 9);
//     PrintArray(numbers);   
//     Console.WriteLine(GetSummPositive(numbers));
//     Console.WriteLine(GetSummNegative(numbers));
// }
// int GetSummPositive(int[] numbers)
// {
//     int sum = 0;
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         if (numbers[i] > 0)
//             sum += numbers[i];
//     } 
//     return sum;
// }
// int GetSummNegative(int[] numbers)
// {
//     int sum = 0;
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         if (numbers[i] < 0)
//             sum += numbers[i];
//     } 
//         return sum;
// }
// void FillArray(int[] numbers, int minValue = 0, int maxValue = 100)
// {
//     maxValue++;
//     Random random = new Random();
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = random.Next(-9, 10);
//     } 
// }   
// void PrintArray(int[] numbers)
// {
//     Console.WriteLine("Вывод массива:");
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.WriteLine();
// }
// Zadacha_31();





// Напишите программу замены элементов массива: положительные элементы замените на 
// соответствующие отрицательные, и наоборот.
// void Zadacha_32()
// {
//     Random random = new Random();
//     int size = random.Next(-10, 10);
//     int[] numbers = new int[12];
//     FillArray(numbers, -10, 9);
//     PrintArray(numbers);
//     ChangeValue(numbers);
//     PrintArray(numbers);
// }
// void ChangeValue(int[] numbers)
// {
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] *= -1;
//     }
// }
// void FillArray(int[] numbers, int minValue = 0, int maxValue = 100)
// {
//     maxValue++;
//     Random random = new Random();
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = random.Next(-9, 10);
//     }
// }
// void PrintArray(int[] numbers)
// {
//     Console.WriteLine("Вывод массива:");
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.WriteLine();
// }
// Zadacha_32();



// Задайте массив. Наполните программу, которая определяет, присутствует ли заданное число в массиве.
// void Zadacha_33()
// {
//     Random random = new Random();
//     int size = random.Next(-10, 10);
//     int[] numbers = new int[12];
//     Console.WriteLine("Введите число для поиска в массиве");
//     int check =Convert.ToInt32(Console.ReadLine());
//     FillArray(numbers, -10, 9);
//     PrintArray(numbers, check);
//     CheckArray(numbers, check);
// }
// void CheckArray(int[] numbers, int check)
// {
//     bool flag = false;
//     for(int i = 0; !flag && i < numbers.Length; i++)
//     {  
//         if(numbers[i] == check)
//         {
//             flag = true;
//         }
//     }
//     // int i = 0; 
//     // while(!flag && i < numbers.Length)
//     // {
//     //     if(numbers[i] == check)
//     //     {
//     //         flag = true;
//     //     }
//     //     i++;
//     // }
//     if(flag)
//     Console.Write($"Число {check} находится в массиве ");
//     else
//     Console.Write($"Число {check} не находится в массиве ");
// }

// void FillArray(int[] numbers, int minValue = 0, int maxValue = 100)
// {
//     maxValue++;
//     Random random = new Random();
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = random.Next(-9, 10);
//     }
// }
// void PrintArray(int[] numbers, int check)
// {
//     Console.WriteLine("Вывод массива:");
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.WriteLine();
// }
// Zadacha_33();



// Задайте одномерный массив, состоящий из случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99].
// void Zadacha_35()
// {
//     Random random = new Random();
//     int size = random.Next(0, 150);
//     int[] numbers = new int[10];
//     FillArray(numbers, 0, 150);
//     PrintArray(numbers);
//     FindArray(numbers);
// }
// void FillArray(int[] numbers, int minValue = 0, int maxValue = 150)
// {
//     maxValue++;
//     Random random = new Random();
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = random.Next(0, 150);
//     }
// }
// void PrintArray(int[] numbers)
// {
//     Console.WriteLine("Вывод массива:");
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.WriteLine();
// }
// void FindArray(int[] numbers)
// {
//     int count = 0;
//     for(int i = 0; i < numbers.Length; i++)
//     {  
//         if(numbers[i] >= 10 && numbers[i] <= 100 )
//         {
//         count++;
//         }
//     }
//     Console.WriteLine($"{count} элементов от 10 до 99 находятся в массиве");
// }    
// Zadacha_35();



// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.
void Zadacha_37()
{
    Random random = new Random();
    int size = 11;
    int[] numbers = new int[size];
    FillArray(numbers, -9, 9);
    PrintArray(numbers);
    FindArray(numbers, size);
}
void FillArray(int[] numbers, int minValue = 0, int maxValue = 150)
{
    maxValue++;
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(-9, 9);
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
void FindArray(int[] numbers, int size)
{
    int maxIndex = size - 1;
    for (int i = 0; i < size / 2; i++)
    {
        Console.WriteLine($"{numbers[i]} * {numbers[maxIndex - i]} = {numbers[i] * numbers[maxIndex - i]} ");
    }
    if (size % 2 == 1)
    {
        Console.WriteLine("средний элемент масива " + numbers[size / 2]);
    }
    Console.WriteLine();
}
Zadacha_37();





