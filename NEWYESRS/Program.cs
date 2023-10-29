Console.Write("Введите цену елки (в рублях): ");
double Price = double.Parse(Console.ReadLine());

Console.Write("Введите процент скидки: ");
double skidka = double.Parse(Console.ReadLine());

double PriseSoSkidkoi = Price - (Price * (skidka / 100));

Console.WriteLine($"Итоговая стоимость елки с учетом скидки: {PriseSoSkidkoi} рублей");
    