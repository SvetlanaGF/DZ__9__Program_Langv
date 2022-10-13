// Задача 68: Напишите программу вычисления 
// функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.WriteLine("Задача 68: Вычислить функцию Аккермана для чисел M и N.");
Console.Write("Введите значение M: ");
int festNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int MetodAkkerman(int m, int n)
{
    if (m == 0) 
        {
            return (n + 1);
        }
    if (m > 0 & n == 0) 
        {
            return MetodAkkerman (m-1, 1);
        }
    if (m > 0 & n > 0)
        {
            return MetodAkkerman(m - 1, MetodAkkerman (m, n-1));
        }
    return 0;
}

Console.WriteLine(MetodAkkerman(festNumber, secondNumber));