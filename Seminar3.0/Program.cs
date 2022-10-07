/* Console.Write("Введите х, ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y, ");
int y = Convert.ToInt32(Console.ReadLine());
if(x > 0 && y > 0)
{
   Console.Write("Первая четверть"); 
}
if(x < 0 && y > 0)
{
   Console.Write("Вторая четверть"); 
}
if(x < 0 && y < 0)
{
   Console.Write("Третья четверть"); 
}
if(x > 0 && y < 0)
{
   Console.Write("Четвертая четверть"); 
} */

/* Задача 18: Напишите программу, которая по заданному номеру четверти, показывает 
диапазон возможных координат точек в этой четверти (x и y).*/

/* Console.Write("Введите номер четверти,  ");
int n = Convert.ToInt32(Console.ReadLine());
if(n > 4 | n < 1)
{
    Console.WriteLine("Введите номер от 1 до 4");
}
if (n == 1)
{
    Console.WriteLine("x > 0, y > 0");
}
if (n == 2)
{
    Console.WriteLine("x < 0, y > 0");
}
if (n == 3)
{
    Console.WriteLine("x < 0, y < 0");
}
if (n == 4)
{
    Console.WriteLine("x > 0, y < 0");
} */ 

/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21 */

/* d = √ (х А – х В) 2 + (у А – у В) 2 формула */

/* Console.WriteLine("A1 (x1;y1), A2 (x2;y2) ");
Console.Write("Input x1: ");
int x1=Convert.ToInt32(Console.ReadLine());
Console.Write("Input y1: ");
int y1=Convert.ToInt32(Console.ReadLine());
Console.Write("Input x2: ");
int x2=Convert.ToInt32(Console.ReadLine());
Console.Write("Input y2: ");
int y2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("A1A2 lenght is: "+Math.Round(Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)),2)); */

/*Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4 
Console.WriteLine("Input N: ");
string N=Console.ReadLine();
string Check (string N)                                         // Процедура проверки значений введенной строки
{
    m1:
    while (N=="")
    {
        Console.Write("Your String is empty, try again: ");     // Проверка ввода пустой строки
        N=Console.ReadLine();
    }
  
    try{                                
        Convert.ToInt32(N);                                     //Блок проверки ввода строки а не числа
    }
    catch (FormatException)
    {
        Console.Write ("You String is not a number, try again: ");
        N=Console.ReadLine();
        goto m1;
    }
    catch (OverflowException)                                   //Блок проверки переполнения типа int при конвертировании строки
    
    {
      Console.Write ("You number, try again (number must be between -2 147 483 648 and 2 147 483 647): ");  
      N=Console.ReadLine();
      goto m1;
    }
    
    return N;
}
int Num=Convert.ToInt32(Check(N));
Console.Write("|  ");
for (int i=1; i<Num+1; i++ ) Console.Write(i*i+"  |  "); */

bool one = true;
while (one)
{
    try
    {
        Console.Write("Введите число N: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int index = 0;
        for(int i = 1; i <= num; i++)
        {
            index = (int)Math.Pow(i, 2);
            if (i == num) Console.Write(index + ".");
            else
                Console.Write(index + ", ");
        }
        one = false;
    }
    catch
    {
        Console.WriteLine("Ошибка ввода, попробуйте еще раз: ");
    }
}





