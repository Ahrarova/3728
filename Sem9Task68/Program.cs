// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// считывание данных пользователя
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

// вычисление функции Аккермана. 
// однако, для значения m >= 4, разложение функции очень большое по любому типичному показателю.
 int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}


int n = ReadData("Введите число M: ");
int m = ReadData("Введите число N: ");
int result = Akkerman(n,m);
PrintResult(result);