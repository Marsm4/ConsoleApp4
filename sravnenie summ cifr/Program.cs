Console.WriteLine("Введите первое натуральное число:");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе натуральное число:");
int number2 = int.Parse(Console.ReadLine());

if (number1 > 109109 || number2 > 109109)
{
    Console.WriteLine("Одно из чисел превышает 100. Пожалуйста, введите натуральные числа, каждое из которых не превышает 100.");
}
else
{

    int sumOfDigits1 = CalculateSumOfDigits(number1);
    int sumOfDigits2 = CalculateSumOfDigits(number2);

    Console.WriteLine("Ответ:");
    if (sumOfDigits1 > sumOfDigits2)
    {
        Console.WriteLine("1");
    }
    else if (sumOfDigits2 > sumOfDigits1)
    {
        Console.WriteLine("2");
    }
    else
    {
        Console.WriteLine("0");
    }
    static int CalculateSumOfDigits(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
}