// задаем массив
char[] digit = Console.ReadLine().ToCharArray();
// условие: если длина массива больше либо равно 3, то выводим третью цифру
if (digit.Length >= 3)
{
    Console.WriteLine(digit[2]);
}
else
{
    // если длина массива меньше 3, говорим что третьей цифры нет
    Console.WriteLine("третьей цифры нет");
}