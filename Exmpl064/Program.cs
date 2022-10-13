// Задача 64: Задайте значение N. Напишите программу, которая выведет все чётные числа 
// в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "4, 2"
// N = 8 -> "8, 6, 4, 2"

Console.Clear();
Console.WriteLine("Задача 64: Вывести чётные числа в промежутке от N до 1.");
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

void EvenNumbers (int k)
{
    if (k%2 == 0)
    {
        Console.WriteLine($"\t i равно {k}");
    }
    k = k-1;
    if (k >= 1)
        EvenNumbers (k);
}
EvenNumbers (n);
