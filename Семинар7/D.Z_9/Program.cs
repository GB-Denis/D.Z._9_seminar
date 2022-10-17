// // 
void Zadacha64()
{
    // Задайте значения M и N. Напишите рекурсивный метод, 
    // который выведет все натуральные числа кратные 3-ём в промежутке от M до N.
    Console.WriteLine("Введите первое число");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число, оно должно быть больше чем первое ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    FindNatural(n, m);
}
void FindNatural(int n, int a = 0)
{
    if( a % 3 == 0)
    {
    Console.WriteLine(a);
    }
    a++;
    if (a > n)
    {
        return;
    }
    FindNatural(n, a);
}
Zadacha64();






void Zadacha66()
{
    // Задайте значения M и N. Напишите программу, 
    // которая найдёт сумму натуральных элементов в промежутке от M до N.
    Console.WriteLine("Введите 1 число");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите 2 число");
    int n = Convert.ToInt32(Console.ReadLine());
    int sum = m;
    Console.WriteLine(SumNum(m, n, sum)); 
    Console.WriteLine($"сумма чисел от числа {m} до {n} = {SumNum(m, n, sum)}");  
}
int SumNum(int m, int n, int sum)
{ 
    if (m >= n)
    {
        return sum;
    }
    m++;
    sum = sum + m;
    return SumNum(m, n, sum);
}
Zadacha66();








void Zadacha68()
{
    Console.WriteLine("Введите 1 число");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите 2 число");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Akkerman(m,n));
    int Akkerman(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        if (m > 0 && n == 0)
        {
            return Akkerman(m - 1, 1);
        }
        return Akkerman(m - 1, Akkerman(m, n - 1));

    }
}
Zadacha68();