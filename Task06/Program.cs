﻿// Напишите программу, которая:
// 1. на вход принимает число
// 2. выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Например:
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0) Console.WriteLine("Введенное число является четным");
else Console.WriteLine("Введенное число не является четным");