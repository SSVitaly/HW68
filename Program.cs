// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.Clear();

Console.WriteLine("Вычислим функцию Аккермана A(m,n) для неотрицательных аргументов");
Console.WriteLine("Введите аргумент m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите аргумент n:");
int n = Convert.ToInt32(Console.ReadLine());

int Ackermann(int m, int n)
{
if (m == 0)
{
    return n+1;
}
else
{
    if (n == 0)
    {
        return Ackermann((m-1), 1);
    }
    else
    {
        return Ackermann(m-1, Ackermann(m, (n-1)));
    }
}
}
Console.WriteLine($"Значение функции Аккермана A(m,n) для неотрицательных аргументов m = {m} и n = {n}: {Ackermann(m,n)}");
