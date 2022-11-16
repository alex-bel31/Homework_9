// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от 1 до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Clear();
Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу,"
                 +"которая найдёт сумму натуральных элементов в промежутке от 1 до N.");
int number = InputNumbers("Введите число N: ");
int result = ShowNum(number);
Console.WriteLine($"N = {number} -> {result}");

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int ShowNum(int number)
{
    if (number == 1)
    {
        return 1;
    }
    return number + ShowNum(number - 1);
}



