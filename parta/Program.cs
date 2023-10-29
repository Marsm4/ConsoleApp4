int maxStudentsPerClass = 105105; // максимально количество учащиехся в классе
Console.WriteLine("максимально количество учащиехся в классе 105105:");
Console.WriteLine("");
Console.WriteLine("Введите количество учащихся в первом классе:");
int studentsClass1 = Convert.ToInt32(Console.ReadLine());

if (studentsClass1 > maxStudentsPerClass)
{
    Console.WriteLine($"Количество учащихся в первом классе превышает {maxStudentsPerClass}. Пожалуйста, введите меньшее значение.");
    return;
}

Console.WriteLine("Введите количество учащихся во втором классе:");
int studentsClass2 = Convert.ToInt32(Console.ReadLine());

if (studentsClass2 > maxStudentsPerClass)
{
    Console.WriteLine($"Количество учащихся во втором классе превышает {maxStudentsPerClass}. Пожалуйста, введите меньшее значение.");
    return;
}

Console.WriteLine("Введите количество учащихся в третьем классе:");
int studentsClass3 = Convert.ToInt32(Console.ReadLine());

if (studentsClass3 > maxStudentsPerClass)
{
    Console.WriteLine($"Количество учащихся в третьем классе превышает {maxStudentsPerClass}. Пожалуйста, введите меньшее значение.");
    return;
}

int desksClass1 = (int)Math.Ceiling((double)studentsClass1 / 2);
int desksClass2 = (int)Math.Ceiling((double)studentsClass2 / 2);
int desksClass3 = (int)Math.Ceiling((double)studentsClass3 / 2);

int totalDesks = desksClass1 + desksClass2 + desksClass3;

Console.WriteLine($"Наименьшее число парт, которое нужно приобрести для 1 класса: {desksClass1}");
Console.WriteLine($"Наименьшее число парт, которое нужно приобрести для 2 класса: {desksClass2}");
Console.WriteLine($"Наименьшее число парт, которое нужно приобрести для 3 класса: {desksClass3}");
Console.WriteLine($"Наименьшее число парт, которое нужно приобрести для 3 классов: {totalDesks}");
