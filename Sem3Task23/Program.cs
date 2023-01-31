﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов 
// чисел от 1 до N
// 3 -> 1, 8, 27 
// 5 -> 1, 8, 27, 64, 125

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Выводим результат пользователю
void PrintData(string msg1, string msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}

// вывод нахождения степени чисел от 1 до N
string LineBuilder(int n, int p)
{
    string res = String.Empty;
    for (int i = 1; i <= n; i++)
    {
        res += Math.Pow(i, p).ToString() + "\t ";
    }
    return res;
}

// Ввод данных
int num = ReadData("Введите N: ");

//Собираем первую строчку таблицы
string line1 = LineBuilder(num, 1);
//Собираем вторую строчку таблицы
string line2 = LineBuilder(num, 3);

// Вывод данных
PrintData(line1,line2);
