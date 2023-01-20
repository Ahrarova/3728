// напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа

// вариант решения 1

// System.Random numSintezator = new System.Random();

// int rdmNum = numSintezator.Next(10, 100);

// Console.WriteLine("Случайное число: " + rdmNum);

// int digit1 = rdmNum / 10;
// int digit2 = rdmNum % 10;

// if (digit1 > digit2)
// {
//     Console.WriteLine("Цифра 1 больше цифры 2: " + digit1 + " " + digit2);
// }
// else
// {
//     Console.WriteLine("Цифра 2 больше цифры 1: " + digit1 + " " + digit2);
// }


// вариант 2

System.Random numSintezator = new System.Random();


char[] digits = numSintezator.Next(10,100).ToString().ToCharArray();

Console.WriteLine(digits);
int digit1 = (int)digits[0]-48;
int digit2 = (int)digits[1]-48;
// ТЕРНАРНЫЙ ОПЕРАТОР если digit1 будет больше digit2, то в переменную resNum положется значение digit1, если нет - digit2
int resNum = digit1>digit2?digit1:digit2; 
Console.WriteLine(resNum);
