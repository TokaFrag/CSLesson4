// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

void Print(string text)
{
    Console.WriteLine(text);
}

int GetNumber(string description)
{
    int number;
    Print($"{description} => ");
    while (true)
    {
        string temp = Console.ReadLine();
        if (int.TryParse(temp, out number))
        {
            return number;
        }
        Print($"This number \"{temp}\" is not correct. Try again. => ");
    }
}

int CountNumber(int number)
{
    int count = 0;
    if (number > 0)
    {
        count = (int)Math.Log10(number) + 1;
    }
    return count;
}

int number = GetNumber("Input number");
Console.WriteLine(CountNumber(number));