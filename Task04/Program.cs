// Напишите программу, которая:
// 1. принимает на вход три числа
// 2. выдаёт максимальное из этих чисел.

// Например:
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.WriteLine("Введите первое целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine()); //считываем первое введенное число
Console.WriteLine("Введите второе целое число: ");
int number2 = Convert.ToInt32(Console.ReadLine()); //считываем второе введенное число
Console.WriteLine("Введите третье целое число: ");
int number3 = Convert.ToInt32(Console.ReadLine()); //считываем третье введенное число
int max = number1;

if (number1 > max) max = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;

Console.WriteLine($"max = {max}");
