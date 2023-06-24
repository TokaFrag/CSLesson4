// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

void Print(string text)
{
    Console.WriteLine(text);
}

// int GetNumber(string description)
// {
//     int number;
//     Print($"{description} => ");
//     while (true)
//     {
//         string temp = Console.ReadLine();
//         if (int.TryParse(temp, out number))
//         {
//             return number;
//         }
//         Print($"This number \"{temp}\" is not correct. Try again. => ");
//     }
// }

int[] arr = new int[8];
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    for (int i = 0; index < length; i++)
    {
        collection[index] = new Random().Next(0, 2);
        index++;
    }
    // Print($"Multiple from 1 to {number} is {result}:");
    Console.WriteLine($"[{string.Join(", ", collection)}]");
}

// int number = GetNumber("Input length array");
FillArray(arr);