// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

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

int GetMultiple(int number)
{
    int result = 1;
    for (int i = 1; i <= number; i++)
    {
        result = result * i;
    }
    Print($"Multiple from 1 to {number} is {result}:");
    return result;
}

int number = GetNumber("Input number");
GetMultiple(number);