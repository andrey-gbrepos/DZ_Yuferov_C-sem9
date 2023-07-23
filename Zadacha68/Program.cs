//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

using System;
using static System.Console;

Clear();
WriteLine("Программа, с помощью рекурсии, вычисляет функцию Аккермана"); 
WriteLine();
Write("Задайте первое неотрицательное число: ");
int numM = int.Parse(ReadLine());

Write("Задайте второе неотрицательное число: ");
int numN = int.Parse(ReadLine());

WriteLine(funcAkkerman (numM, numN));

int funcAkkerman (int num1, int num2)
{
    if(num1 == 0) return num2 + 1;
    if(num1 != 0 && num2 == 0)  return funcAkkerman (num1 - 1, 1);
    else return funcAkkerman (num1 - 1, funcAkkerman (num1, num2 - 1));
}
