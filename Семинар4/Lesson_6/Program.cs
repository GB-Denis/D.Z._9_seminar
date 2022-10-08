// // Решение задач
// void Zadacha_39()
// {
//     // Напишите программу, которая перевернёт одномерный массив 
//     // (последний элемент будет на первом месте, а первый - на последнем и т.д.)
//     int size = 10;
//     int[] numbers = new int[size]; 
//     FillArray(numbers, -10, 10);
//     PrintArray(numbers);
//     ReverseArray(numbers);
//     PrintArray(numbers);
// }
// void ReverseArray(int[] numbers)
// {
//     int size = numbers.Length;
//     int maxIndex = size - 1;
//     for (int i = 0; i < numbers.Length / 2; i++)
//     {
//         (numbers[i], numbers[maxIndex - i]) = (numbers[maxIndex - i], numbers[i]);
//     }
// }
// void FillArray(int[] numbers, int minValue, int maxValue)
// {
//     maxValue++;
//     int size = numbers.Length;
//     Random random = new Random();
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = random.Next(maxValue = -10, maxValue = 10);
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
// Zadacha_39();





// void Zadacha_40()
// {
//     // Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать 
//     // треугольник со сторонами такой длинны.
//     Console.WriteLine("Введите координаты предпологаемого треугольника");
//     Console.WriteLine("Введите сторону A");
//     int a = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите сторону B");
//     int b = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите сторону C");
//     int c = Convert.ToInt32(Console.ReadLine());
//     if (a + b > c && a + c > b && b + c > a)
//     {
//         Console.WriteLine("Треугольник может существовать");
//     }
//     else Console.WriteLine("Треугольник НЕ может существовать");
// }
// Zadacha_40();




// void Zadacha_42()
// {
//     Console.WriteLine("Введите число для преобразования в двоичную систему");
//     int number = Convert.ToInt32(Console.ReadLine());
//     string result = Convert.ToString(number, 2);
//     Console.WriteLine($"{number} -> {result}");
// }
// Zadacha_42();




// void Zadacha_44()
// {
//     // Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибонначи 0 и 1.
//     Console.WriteLine("Введите N число Фибонначи");
//     int size = Convert.ToInt32(Console.ReadLine());
//     int a = 0;
//     int b = 1;
//     double[] numbers = new double[size];
//     numbers[0] = a;
//     numbers[1] = b;
//     for (int i = 2; i < numbers.Length; i++)
//     {
//         numbers[i] = numbers[i - 2] + numbers[i - 1];
//     }
//     PrintArray(numbers);
// }
// void PrintArray(double[] numbers)
// {
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(" " + numbers[i]);
//     }
//     Console.WriteLine();
// }
// Zadacha_44();




// void Zadacha_45()
// {
//     // Напишите программу, которая будет создавать копию заданного массива
//     // с помошью поэлемнтарного копирования.
//     int size = 10;
//     int[] numbers = new int[size];
//     int[] new_numbers = new int[size];
//     FillArray(numbers, 0, 10);
//     PrintArray(numbers);
//     CopyArray(numbers, new_numbers);
//     PrintArray(new_numbers);
// }
// void CopyArray(int[] numbers, int[] new_numbers)
// {
//       for(int i = 0; i < numbers.Length; i++)
//     {
//         new_numbers[i] = numbers[i];
//     }
// }
// void FillArray(int[] numbers, int minValue, int maxValue)
// {
//     maxValue++;
//     int size = numbers.Length;
//     Random random = new Random();
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = random.Next(maxValue = 0, maxValue = 10);
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
// Zadacha_45();



