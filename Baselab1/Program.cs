using System;

int x, y;
Console.WriteLine("Введите значение для x ->");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение для y ->");
y = Convert.ToInt32(Console.ReadLine());

int c = x;
x = y;
y = c;

x = x - y;
y = x + y;
x = (x - y) * (-1);
Console.WriteLine($"x = {x} y = {y}");



