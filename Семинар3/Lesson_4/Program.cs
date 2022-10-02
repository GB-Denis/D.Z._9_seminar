// Zadacha_24();
// void Zadacha_24()
// {
//     // Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//     Console.WriteLine("Введите число");
//     int number = Convert.ToInt32(Console.ReadLine());
//     int sum = 0;
//     for (int i = 1; i <= number; i++)
//     {
//         sum += i;
//     }
//     Console.Write($"{sum}");
    
// }


// Zadacha_26();
// void Zadacha_26()
// {
//     // Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//     Console.WriteLine("Введите число");
//         string number = Console.ReadLine();
//         Console.WriteLine($"Количество цифр в числе {number} = {number.Length}");
        
//         // Либо второе решение.

//         // int number = Convert.ToInt32(Console.ReadLine());
//         // int current = number;
//         // int count = 0;
//         // while (current > 0)
//         // {
//         //     current = current / 10;
//         //     count = count +1;
//         // }
//         // Console.WriteLine($"Количество цифр в числе {number} = {count}");

        
        
    

// }


// Zadacha_28();
// void Zadacha_28()
// {
//     //    Напишите программу, которая принимает на вход число (N) и выдаёт сумму чисел от 1 до N.
//     Console.WriteLine("Введите число");
//     int number = Convert.ToInt32(Console.ReadLine());
//     int sum = 1;
//     for (int i = 1; i <= number; i++)
//     {
//         sum = sum * i;
//     }
//     Console.Write($"{sum}");
// }


void Zadacha_30()
{
    // Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и еденицами в случайном порядке.
    Random random = new Random();
    int size = random.Next(4, 10);
    int[] numbers = new int[size];
    Console.WriteLine(size);
    FillArray(numbers);
    // Команда на ручной ввод заполнения массива!
    // for (int i = 0; i < numbers.Length; i++)
    // {
    //     Console.WriteLine($"Введите {i+1}-й элемент массива");
    //     numbers[i] = Convert.ToInt32(Console.ReadLine());
    // }
    PrintArray(numbers);
}
    void FillArray(int[] num)
    {
        Random random = new Random();
        for(int i = 0; i < num.Length; i++)
        {
        num[i] = random.Next(0, 2);
        }
    } 
    void PrintArray(int[] num)
    {
        for (int i =0; i < num.Length; i++)
        {
        Console.Write(num[i] + ", ");
        }
        Console.Write("\b\b");
        Console.WriteLine();
    }
    Zadacha_30();
