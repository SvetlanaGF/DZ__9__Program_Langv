// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Console.Clear();
Console.WriteLine("Задача 66: Найдите сумму натуральных элементов в промежутке от M до N.");
Console.Write("Введите значение M: ");
int nachalo = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
void SumNaturalNumber(int m)
{
        sum = sum + m;
        m = m + 1;
        if (m <= n)
        SumNaturalNumber(m);
}
SumNaturalNumber(nachalo);
Console.WriteLine($"\nСумма натуральных элементов от {nachalo} до {n} = {sum}");
Console.WriteLine();