﻿//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Введите трехзначное число");
int a = int.Parse(Console.ReadLine()!);
if (a<1000 & a >99)
{int b = (a%100)/10;

Console.WriteLine(b); }
else {Console.WriteLine("число не является трехзначным"); }