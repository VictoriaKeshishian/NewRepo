/* Напишите программу, которая выводит случайное число 
из отрезка [10,99] и показывает наибольшую цифру числа 

int n = new Random().Next(10,99);
int first = n/10;
int second = n%10;

if (first > second)
    {
        Console.WriteLine(first);
    }
else
    {
        Console.WriteLine(second);
    }
*/

/* Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98 */

/* int n = new Random().Next(100,1000);
int a = n/100;
int b = n%10;

Console.WriteLine(n);
Console.Write(a,b); */

/* 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму. Если число 1 не кратно числу 2, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/

/* Console.WriteLine("Введите первое число, ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число, ");
int b = Convert.ToInt32(Console.ReadLine());
if(a%b == 0)
    {
        Console.Write("кратно");
    }
else
    {
        Console.Write("Не кратно, остаток ");
        Console.Write(a%b);
    } */ 

    /* 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет 
46 -> нет 
161 -> да

Console.WriteLine("Введите первое число, ");
int a = Convert.ToInt32(Console.ReadLine());
if(a%7 == 0)
    if(a%23 == 0)
        {
            Console.Write("Да");
        }

else
    {
        Console.Write("Нет");
    }
*/

/* 16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет
*/

Console.WriteLine("Введите первое число, ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число, ");
int b = Convert.ToInt32(Console.ReadLine());
if(a*a == b | b*b == a)
    {
        Console.WriteLine("Да");
    }
else 
    {
        Console.WriteLine("Нет");
    }
