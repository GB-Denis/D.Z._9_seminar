// 
// void Zadacha63()
// {
//     // Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
//     // Решить с помошью рекурсии

//     Console.WriteLine("Введите значение N");
//     int n = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine();
//     FindNatural(n);
// }
// void FindNatural(int n, int a = 0)
// {
//     a++;
//     Console.WriteLine(a);
//     if (a >= n)
//     {
//         return;
//     }
//     FindNatural(n, a);

// }
// Zadacha63();


// void Zadacha65()
// {
//     // Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N
//     Console.WriteLine("Введите значение N");
//     int n = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите значение M");
//     int m = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine();
//     FindNatural(n, m);
// }
// void FindNatural(int n, int a = 0)
// {

//     Console.WriteLine(a);
//     a++;
//     if (a > n)
//     {
//         return;
//     }
//     FindNatural(n, a);

// }
// Zadacha65();


// void Zadacha67()
// {
//     // Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
//     Console.WriteLine("Введите любое целое число");
//     int num = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine(SumNum(num));
// }
// int SumNum(int num, int sum = 0)
// {
//     if (num == 0)
//     {
//         return sum;
//     }
//     sum = sum + num % 10;
//     num = num / 10;
//     return SumNum(num, sum);
// }
// Zadacha67();


void Zadacha69()
{
    // Напишите программу которая на вход принимает два числа A и B, 
    // и возводит число A в целую степень B с помощью рекурсии.
    Console.WriteLine("Введите значение A");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение B");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Pow(a, b);
}
// void Pow(int a, int b, int result = 1) // Решение с помощью цикла
// {
//     for (int i = 0; i < b; i++)
//     {
//         result *= a;
//     }
//     Console.WriteLine($"{a}^{b} = {result}");
// }
void Pow(int a, int b, int i = 0, int result = 1) // Решение с помошью рекурсии
{
    if (i >= b)
    {
       Console.WriteLine($"{a}^{b} = {result}");
       return; 
    }
    result *= a;
    i++;
    Pow(a, b, i, result);
}
Zadacha69();