// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных 
// числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

Console.WriteLine("Введите M");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите N");
int b = Convert.ToInt32(Console.ReadLine());

int AkkermanFunction(int a, int b)
{
    if (a == 0) return b + 1;
    if (a != 0 && b == 0) return AkkermanFunction(a - 1, 1);
    if (a > 0 && b > 0) return AkkermanFunction(a - 1, AkkermanFunction(a, b - 1));
    return AkkermanFunction(a, b);
}
Console.WriteLine(AkkermanFunction(a, b));
