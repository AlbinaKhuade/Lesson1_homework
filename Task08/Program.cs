// Напишите программу, которая:
// 1. на вход принимает число (N),
// 2. на выходе показывает все чётные числа от 1 до N.

// Например:
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int temp = 1;
int count = 0;

Console.WriteLine($"Все четные числа от 1 до {number}: ");
while (count < number)
{
    if (temp % 2 == 0) Console.Write($"{temp} ");
    count++;
    temp++;
}
