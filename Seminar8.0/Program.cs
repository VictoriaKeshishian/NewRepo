/* Задача 53. Задайте двумерный массив. Напишите программу, которая поменяет местами 
первую и последнюю строку массива.
*/

/*

int[,] array = new int[4, 4];


fillArray(array);
printArray(array);
swapLines(array);
printArray(array);

void swapLines(int[,] arr)
{
    
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int temp = arr[0, j];
            arr[0, j] = arr[arr.GetLength(0) - 1, j];
            arr[arr.GetLength(0) - 1, j] = temp;
        }
}

void fillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}


void printArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

*/

/* Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя. */

/* int[,] array = new int[4, 4];


fillArray(array);
printArray(array);
unwrap(array);
printArray(array);

void unwrap(int[,] arr)
{
for(int i = 0; i < array.GetLength(0); i++)
   for(int j = i + 1; j < array.GetLength(1); j++)
   {
      var temp = array[i,j];
      array[i,j] = array[j,i];
      array[j,i] = temp;
   }
}

void fillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}


void printArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
*/

/* Задача 59. Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
9 2 3
4 2 4
2 6 7
*/
int[,] array = new int[5, 5];
int[,] array2 = new int[array.GetLength(0) -1, array.GetLength(1) - 1];
int coordinateI = 0;
int coordinateJ = 0;

fillArray(array);
printArray(array);
deletingRowAndColumn(array, array2);
Console.WriteLine(coordinateI);
Console.WriteLine(coordinateJ);
printArray(array2);


void deletingRowAndColumn(int[,] matrix, int[,] array2)
{
    int min = matrix[0, 0];
    int flagI = 0;
    int flagJ = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i, j] < min) {
                min = matrix[i, j];
                coordinateI = i;
                coordinateJ = j;
            }
        }
    }
    for (int i = 0; i < matrix.GetLength(0) -1; i++)
    {
        for (int j = 0; j < matrix.GetLength(1) -1; j++)
        {
            if(i < coordinateI) {
                flagI = 0;
            } else {
                flagI = 1;
            }

            if(j < coordinateJ) {
                flagJ = 0;
            } else {
                flagJ = 1;
            }

            array2[i, j] = array[i + flagI, j + flagJ];
        }
    }
}

void fillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}


void printArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
