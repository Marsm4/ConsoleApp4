using System;

class Program
{
    static void Main()
    {
        double originalPrice = 1000; // Цена елки без учета скидки
        double discountPercentage = 10; // Процент скидки

        // Рассчитываем сумму с учетом скидки
        double discountedPrice = originalPrice - (originalPrice * (discountPercentage / 100));

        Console.WriteLine($"Итоговая стоимость елки с учетом скидки: {discountedPrice} рублей");
    }
}