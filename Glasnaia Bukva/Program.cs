Console.WriteLine("Введите строку (не более 10001000 символов):");
string sentence = Console.ReadLine();

if (sentence.Length <= 10)
{
    int vowelsCount = CountVowels(sentence);
    Console.WriteLine($"Количество гласных букв в строке: {vowelsCount}");
}
else
{
    Console.WriteLine("Превышена максимальная длина строки (не более 100100 символов).");
}
    

    static int CountVowels(string sentence)
{
    int count = 0;
    foreach (char c in sentence)
    {
        if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
            c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
        {
            count++;
        }
    }
    return count;
}
