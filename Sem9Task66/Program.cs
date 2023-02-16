// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// метод считывает данные от пользователя
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintResult(int prefix)
{
    Console.WriteLine(prefix);
}

// рекурентный метод нахождения суммы
int RecSumMN(int m, int n)
{
    if (m >= n)
    {
        return n;
    }
    else
    {
        return m + RecSumMN(m + 1, n);
    }
}

// вызов функции для считывания данных
int numM = ReadData("Введите число M: ");
int numN = ReadData("Введите число N: ");

// защита от дурака :)
int res = numM<numN? RecSumMN(numM,numN):RecSumMN(numN,numM);

// печать результата
PrintResult(res);