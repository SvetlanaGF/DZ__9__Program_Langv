// Задача 64: Задайте значение N. Напишите программу, которая выведет все чётные числа 
// в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "4, 2"
// N = 8 -> "8, 6, 4, 2"

Console.Clear();
Console.WriteLine("Задача 64: Вывести чётные числа в промежутке от N до 1.");
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

void EvenNumbers (int k, int limit)
{
    if (k%2 == 0)
    {
    if (k >= limit)
        return;
    Console.WriteLine($"\t i равно {k}");
    k++;
    //i = i-1;
    EvenNumbers (k, limit);
    }
}
    int i=2;
    //for (int i = 1; i < n+1; i++)
    //{
        //Console.WriteLine($"\ti = {i}");
        if (i%2 == 0)
            {
                EvenNumbers (2, n);
            }
    //}

