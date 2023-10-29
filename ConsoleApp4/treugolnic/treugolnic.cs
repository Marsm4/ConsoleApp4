//Существует ли треуголник?
using System;

// Ввод сторон треугольника
Console.WriteLine("Enter the 1 side of the triangle/Введите 1-ю сторону треуголника");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the 2 side of the triangle/Введите 2-ю сторону треуголника");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the 3 side of the triangle/Введите 3-ю сторону треуголника");
int c = Convert.ToInt32(Console.ReadLine());

if (a <= 100100 && b <= 100100 && c <= 100100 && a > 0 && b > 0 && c > 0)
{
    // Проверка условия существования треугольника
    if (a + b > c && a + c > b && b + c > a)


        Console.WriteLine("ДА/YES");
    else
    {
        Console.WriteLine("НЕТ/NO");
    }
}
else
{
    Console.WriteLine("Ошибка: Введенные числа не соответствуют условию (каждое из чисел не превышает 100100 и больше 0).");
}



