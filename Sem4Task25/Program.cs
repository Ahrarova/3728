//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в 
// натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Выводим результат пользователю
void PrintData(int msg)
{
    Console.WriteLine(msg);
}
// Возводим а в степень в
int Pow(int a,int b)
{
    int res = 1;
    while(b>0)
    {
        b=b-1;
        res=res*a;
    }
    return res;
}

// пользователь вводит числа
int a = ReadData("Введите первое число");
int b = ReadData("Введите второе число");

// вызываем метод возведения в степень
int resalt = Pow(a,b);

// выводим результат
PrintData(resalt);


