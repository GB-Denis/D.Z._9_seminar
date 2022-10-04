
// //Используя определение степени числа, напишите цикл, 
// //который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
// void Zadacha_25()
// {
//     Console.WriteLine("Введите число a");
//     int number_a = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите число b");
//     int number_b = Convert.ToInt32(Console.ReadLine());
//     int sum = 1;
//     for (int i = 1; i <= number_b; i++)
//     {
//         sum = (sum) * number_a;
        
//     }
//     Console.Write($"Число {number_a} в степени {number_b} равно {sum}");
// }
// Zadacha_25();



// // Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// void Zadacha_27()
// {
//     Console.WriteLine("Введите число");
//     int number = Convert.ToInt32(Console.ReadLine());
//     int n = number;
//     int sum = 0;
//         while (n > 0)
//         {
//                 sum = sum + n % 10;
//                 n = n /10 ;
//         }
//     Console.Write($"В числе {number}, сумма цифр = {sum}"); 
// }    
// Zadacha_27();




// // Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
// void Zadacha_29()
// {
//     int size = 8;
//     int[] numbers = new int[size];
//     FillArray(numbers);
//     PrintArray(numbers);
//     void FillArray(int[] num)
//     {
//         Random random = new Random();
//         for(int i = 0; i < num.Length; i++)
//         {
//         num[i] = random.Next(-100, 100);
//         }
//     } 
//     void PrintArray(int[] num)
//     {
//         for (int i =0; i < num.Length; i++)
//         {
//         Console.Write(num[i] + ", ");
//         }
//         Console.Write("\b\b");
//         Console.WriteLine();
//     }
//     int temp;
// for (int i = 0; i < numbers.Length - 1; i++)
// {
//     for (int j = i + 1; j < numbers.Length; j++)
//     {
//         if (Math.Abs(numbers[i]) > Math.Abs(numbers[j]))
//         {
//             temp = numbers[i];
//             numbers[i] = numbers[j];
//             numbers[j] = temp;
//         }
//     }
// }
// for (int i = 0; i < numbers.Length; i++)
// {
//     Console.Write(numbers[i] + ", ");
// }
// }
// Zadacha_29();
