//Задача 66: Задайте значения M и N. Напишите программу, которая 
//найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

using System;
using static System.Console;

Clear();
WriteLine("Программа, с помощью рекурсии, выводит все натуральные числа в промежутке"); 
WriteLine("от одного заданного числа до другого");
WriteLine();
Write("Задайте первое натуральное число: ");
int num1 = int.Parse(ReadLine());

Write("Задайте второе натуральное число: ");
int num2 = int.Parse(ReadLine());

WriteLine(OutNaturalNum (num1, num2));

string OutNaturalNum (int numA, int numB)
{ 
    if(numA <= numB)
    {
    if (numA == numB)
        {
        return Convert.ToString(numB);
        }
        else
        {    
        return ($"{numA} {OutNaturalNum(numA+1, numB)}");    
        }
    } 
    else
    {
        if (numA == numB)
        {
        return Convert.ToString(numB);
        }
        else
        {    
        return ($"{numA} {OutNaturalNum(numA-1, numB)}");    
        }
    } 
}