/* Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20 */

/* int [] array = new int[12];
int index = 0;
int respos = 0;
int resneg = 0;

void FillArray(int[] array, int from, int to)
{
      for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(from, to+1); 
    }
}

void PrintArray(int[] array)
{
       for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, "); 
    }
    System.Console.Write($"{array[array.Length - 1]}"); 
} */

//
/*Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] array = new Int32[4]; // задали новый массив с 4 элементами

randomFilling(array, -9, 10); // задаем функция в массиве со значениеями диапазона чисел в массиве
arrayOutput(array); // задаем функция в массиве для вывода массива на экран
signChange(array); // функция для замены знака в элементах массива
arrayOutput(array); // еще раз выводим массив на экран после всех проделанных с ним действий

void signChange(int[] arr) // функция для замены знака в массиве
{
for (int i = 0; i < arr.Length; i++) // условия функции
{
arr[i] = arr[i] * -1; // чтобы заменить знак каждый элемент массива умножаем на -1
}
}

void randomFilling(int[] arr, int min, int max) // функция для рандомных значений массива, задаем в нее две переменные
{
for (int i = 0; i < arr.Length; i++) // условия функции
{
arr[i] = new Random().Next(min, max); // даем массиву рандомные значения в диапазоне min, max
}
}

void arrayOutput(int[] arr) // функция вывода на экран 
{
for (int i = 0; i < arr.Length; i++) // условия функции
{
Console.Write($"{arr[i]}");
if (i < (arr.Length-1)) Console.Write($", "); // условия вывода функции
}
Console.WriteLine();
}



/*Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да

int[] array = new Int32[10];

randomFilling(array, 0, 100);
arrayOutput(array);

Console.WriteLine("введите число, которое надо найти.");
int number = Convert.ToInt32(Console.ReadLine());
string result = search(array, number)
? $"число {number} содержится в массиве."
: $"число {number} не содержится в массиве.";
Console.WriteLine(result);

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
Console.Write("");
}
}

bool search(int[] array, int searchNumber)
{
bool found = false;
for (int i = 0; i < array.Length; i++)
{
if (searchNumber == array[i])
{
found = true;
break;
}
}

return found;
}

/* Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5 

int[] arr = new Int32[10];

fillMass(arr, -10, 120);
printArray(arr);
numFind(arr);

int[] fillMass(int[] array, int from, int to)
{
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(from, to + 1);
}
return array;
}

void printArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
Console.WriteLine();
}

void numFind(int[] array)
{
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
if (array[i] >= 10 && array[i] <= 99)
{
sum ++;
}
}
Console.WriteLine(sum);
}


/* Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 

int len = new Random().Next(5, 10);
Console.WriteLine(len);

int[] arr = new Int32[len];

double half = Math.Ceiling((Convert.ToDouble(len) / 2));
Console.WriteLine(half);

int[] arr2 = new Int32[Convert.ToInt32(half)];


fillMass(arr, 1, len);
printArray(arr);
numFind(arr, arr2);
printArray(arr2);

int[] fillMass(int[] array, int from, int to)
{
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(from, to + 1);
}
return array;
}

void printArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
Console.WriteLine();
}

int[] numFind(int[] array, int[] array2)
{
for (int i = 0; i < (array.Length)/2; i++)
{
array2[i] = array[i] * array[array.Length - i - 1];
}
if (array.Length % 2 != 0)
{
array2[array.Length / 2] = array[array.Length / 2];
}
return array2;
} */