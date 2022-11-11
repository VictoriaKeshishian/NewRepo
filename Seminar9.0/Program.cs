/* Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6" */

/* Console.WriteLine("Введите число");

int number = Convert.ToInt32(Console.ReadLine());

printNaturalNumbers(1);


void printNaturalNumbers(int n) {

    if(n == number ) {
        Console.Write(n);
    } else {
        Console.Write(n);
        printNaturalNumbers(n+1);
    }
} */


/* Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8" */

/* Console.WriteLine("Введите числа");

int stop = Convert.ToInt32(Console.ReadLine());
int start = Convert.ToInt32(Console.ReadLine());

printNaturalNumbers(start);


void printNaturalNumbers(int n) {

    if(n == stop) {
        Console.Write(n);
    } else {
        Console.Write(n);
        printNaturalNumbers(n+1);
    }
} /*

/* Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9 */
/* Console.WriteLine("Введите число");

int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(numbersSum(number));


int numbersSum(int n) {

    if(n < 10) {
      return  n;
    } else {
        
        return numbersSum(n / 10) + n % 10;  
    }
} */

/*Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B 
с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */

/* Console.WriteLine("Введите число");

int number = Convert.ToInt32(Console.ReadLine());
int degree = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(exponentiation(number, degree));


int exponentiation(int n, int m) {

    if(m == 1) {
      return  n;
    } else {      
        return exponentiation(n, m - 1) * n;  
    }
} */
