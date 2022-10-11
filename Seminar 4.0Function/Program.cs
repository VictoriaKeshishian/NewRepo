/* Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/
/* Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= number; i++)
{
    sum += i;
}

Console.WriteLine(sum); */

/* Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 */

/* 
решение 1
Console.WriteLine("Введите число ");
string a = (Console.ReadLine());
int amount = a.Length;
Console.WriteLine(amount); */

/* 
решение 2
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
int count = 0;
if (num == 0)
{
    count = 1;
}
else while(num != 0)
{
    num /= 10;
    count += 1;
}
Console.WriteLine(count); */

/* 
решение 3
Console.WriteLine("Введите число");

int a = int.Parse(Console.ReadLine());
int count = 0;
while (a != 0)
{
   a = a / 10;
    count++;
}
Console.WriteLine(count); */

/*  Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120 
*/

/* 
int num = int.Parse(Console.ReadLine());

int result = addition(num);

Console.WriteLine(result);


int addition(int number)
{
    int count = 1;
    
    for (int i = 1; i <= number; i++)
    {
        count = count * i; // count *= i;
    }

    return count;
} 
*/

/*Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
заполненный нулями и единицами в случайном порядке.
1,0,1,1,0,1,0,0*/


int[] array = new int[8];
void Itog() {
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 2);
    Console.Write(array[i] + " ");
}

}
Itog();



