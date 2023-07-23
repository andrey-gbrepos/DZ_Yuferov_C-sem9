//Задача 64: Задайте значение N. Напишите программу, которая 
//выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
using System;
using static System.Console;

Clear();
WriteLine("Программа, с помощью рекурсии, выводит все натуральные числа от заданного числа до 1");
WriteLine();
Write("Задайте натуральное число: ");
int num = int.Parse(ReadLine());
WriteLine(OutNaturalNum (num, 1));

string OutNaturalNum (int startNum, int finishNum)
{ 
    if (startNum == finishNum)
    {
        return Convert.ToString(finishNum);
    }
     else
     {    
    return ($"{startNum} {OutNaturalNum(startNum-1, finishNum)}");    
     }
}  
