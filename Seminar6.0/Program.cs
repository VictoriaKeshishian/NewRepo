/* Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6] */


/* int[] array = new Int32[10];
Console.Write("Ваш массив: ");
random(array, 100, 1000);
reverse(array);
output(array);

void random(int[] arr, int min, int max)
{
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(min, max);
    Console.Write(array[i] + " ");
}
}
 
void reverse(int[] arr)
{
for(int i = 0; i < array.Length - 1; i--)
{
    Console.Write(array[i]);
}
}

void output(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(array[i]);
    }
} */


/*
Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/
/*Console.WriteLine("Введите 3 числа");

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

if (a + b > c && a + c > b && b + c > a)
{
    Console.WriteLine("Это треугольник");
} else Console.WriteLine("Это не треугольник");*/


/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/
 /*Console.WriteLine("Введите число");

int number = Convert.ToInt32(Console.ReadLine());

string count = null;
while (number != 0)
{
    count += number % 2;
    number /= 2;
}

for (int i = count.Length - 1; i >= 0; i--)
{
    Console.Write(count[i]);
}
*/

/* Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */

/*Console.WriteLine("Введите число, ");
int fib = Convert.ToInt32(Console.ReadLine());

Console.Write("0,1");
int first = 0;
int second = 1;
int next = 0;
 for (int i = 1; i < fib - 1; i++)
 {
    next = first + second;
    Console.Write(" " + next);
    first = second;
    second = next; 
 } */

/* Задача 45: Напишите программу, которая будет создавать копию 
заданного массива с помощью поэлементного копирования. */

int[] array1 = new Int32[8];
int[] array2 = new Int32[8];

randomFilling(array1, 0, 100);
arrayOutput(array1);
copy(array1, array2);
arrayOutput(array2);

void copy(int[] array1, int[] array2)
{
    for (int i = 0; i < array1.Length; i++)
    {
        array2[i] = array1[i];
    }
}


void randomFilling(int[] arr, int min, int max)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
}

void arrayOutput(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if (i < (arr.Length-1)) Console.Write($", ");
        
    }
    Console.WriteLine(" ");
}
