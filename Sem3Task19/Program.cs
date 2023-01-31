// Напишите программу, которая принимает на вход пятизначное
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Выводим результат пользователю
void PrintData(bool msg)
{
    Console.WriteLine(msg);
}
// Проверка на полиндром
bool PalindromTest (int n)
{
    bool res = false;
    int d1 = n/10000;
    int d2 = (n/1000)%10;
    int d3 = (n/10)%10;
    int d4 = n%10;
    res = (d1==d4)&&(d2==d3)?true:false;
    return res;
}

// выводим число
int Num = ReadData("Введите число: ");
// вызываем метод теста на полиндром
bool resalt = PalindromTest (Num);
// выводим результат
PrintData(resalt);
