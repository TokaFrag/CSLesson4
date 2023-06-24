// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
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


int GetSum(int number)
{
    int sum = 0;
    for (int i = 0; i <= number; i++)
    {
        sum += i;
    }
    Print($"Sum numbers from 1 to {number} is {sum}");
    return sum;
}

int number = GetNumber("Input number");
GetSum(number);