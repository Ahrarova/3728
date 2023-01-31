//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в 
// числе.
// 452 -> 11 
// 82 -> 10 
// 9012 -> 12


//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Выводим результат пользователю
void PrintData(string msg1, int msg2)
{
    Console.Write(msg1);
    Console.Write(msg2);
}
// Метод считает сумму цифр
int SumDigit(int num)
{
    int res =0;
    while(num>0)
    {
        res= res + num%10;
        num=num/10;
    }
    return res;
}

// пользователь вводит число
int number = ReadData("Введите число: ");
// вызов метода подсчета цифр
int res = SumDigit(number);
// выводим результат
PrintData("Сумма цифр: ",res);