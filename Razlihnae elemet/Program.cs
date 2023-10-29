        Console.WriteLine("Задайте число N massiva");
       
        int n = int.Parse(Console.ReadLine());
       
        List<int> elements = new List<int>();

        Console.WriteLine("Запишите через Enter N чисел - элементы ");

for (int i = 0; i < n; i++)
{
    int element = int.Parse(Console.ReadLine());
    if (Math.Abs(element) <= 100)
    {
        elements.Add(element);
    }
    else
    {
        Console.WriteLine("Ошибка: Введенное число не удовлетворяет условию (по модулю не превосходит 100).");
        i--; // Повторить ввод для этого элемента
    }
}

    HashSet<int> uniqueElements = new HashSet<int>(elements);

        int differentElementsCount = uniqueElements.Count;

        if (differentElementsCount == 1)
        {
            differentElementsCount = 1;
        }

        Console.WriteLine("Количество различных элементов ");
        Console.WriteLine(differentElementsCount);
    