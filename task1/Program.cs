﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите первое число");
int num1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2=Convert.ToInt32(Console.ReadLine());
if (num1>num2)
{
    Console.Write("max="+num1);
}
else
{
    Console.Write("max="+num2);
}