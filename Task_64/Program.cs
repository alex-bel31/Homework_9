// Задача 64: Задайте значение N.
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.Clear();
Console.WriteLine("Задача 64: Задайте значение N. Напишите программу,"
                 +"которая выведет все натуральные числа в промежутке от N до 1."
                 +"Выполнить с помощью рекурсии.");
int number = InputNumbers("Введите число N: ");
string result = ShowNum(number);
int index = result.LastIndexOf(',');
result = result.Remove(index, 1);
Console.WriteLine($"N = {number} -> {result}");

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
string ShowNum(int number, int start = 0)
{
        if (number > start)
    {
        return $"{number}, {ShowNum(number-1, start)}";
    }
   return string.Empty;

}

