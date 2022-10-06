// Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.
Console.Clear();
Console.Write("ВВедите первое число:");
int a = int.Parse(Console.ReadLine()!);
Console.Write("ВВедите второе число:");
int b = int.Parse(Console.ReadLine()!);
Console.Write("ВВедите третье число:");
int c = int.Parse(Console.ReadLine()!);
if (a > b)
{
    if (a > c)
    {
        Console.WriteLine($"Максимальное число: {a} ");
    }
    else
    {
        Console.WriteLine($"Максимальное число: {c} ");
    }
}
else if (b > c)
{
    Console.WriteLine($"Максимальное число: {b} ");
}
else
{
    Console.WriteLine($"Максимальное число: {c} ");
}
