
// Zadacha_31();
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

// Zadacha_32();
// // Напишите программу замены элементов массива: положительные элементы замените на 
// // соответствующие отрицательные, и наоборот.
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






