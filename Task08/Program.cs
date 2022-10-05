// Напишите программу, которая:
// 1. на вход принимает число (N),
// 2. на выходе показывает все чётные числа от 1 до N.

// Например:
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2;

if (number < 2) Console.WriteLine($"От 1 до {number} нет четных чисел");
else 
{
    Console.WriteLine($"Все четные числа от 1 до {number}: ");
    while (count < number + 1)
    {
        if (count % 2 == 0) Console.Write($"{count} ");
        count = count + 2; 
    }
}

