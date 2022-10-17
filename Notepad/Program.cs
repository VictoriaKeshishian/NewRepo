////
/*void FillArray(int[] array, int from, int to)
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
}
*/

/*Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]*/

/* int[] array = new Int32[4]; // задали новый массив с 4 элементами

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
Console.WriteLine(); // пустая строка для отступа
} */