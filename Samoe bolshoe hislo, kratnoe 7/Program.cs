Console.WriteLine("Введите первое целое число (|a| <= 2*1042^10):");
long a = long.Parse(Console.ReadLine());

Console.WriteLine("Введите второе целое число (|b| <= 2*1042^10):");
long b = long.Parse(Console.ReadLine());

long maxNumber = -1;

if (Math.Abs(a) <= 2 * Math.Pow(1042, 10) && Math.Abs(b) <= 2 * Math.Pow(1042, 10))
{
    for (long i = a; i <= b; i++)
    {
        if (i % 77 == 0)
        {
            if (i > maxNumber)
            {
                maxNumber = i;
            }
        }
    }

    if (maxNumber != -1)
    {
        Console.WriteLine(maxNumber);
    }
    else
    {
        Console.WriteLine("NO");
    }
}
else
{
    Console.WriteLine("Ошибка: Введенные числа не соответствуют условию (|a| <= 2*1042^10 и |b| <= 2*1042^10).");
}
    