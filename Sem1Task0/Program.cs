//Задача: написать программу, которая на вход принимает число,
// и на выходе выдаёт его квадрат.

string? inputNum = Console.ReadLine();
//Проверяем, чтобы данные не были пустые
if(inputNum!=null)
{

int number = int.Parse(inputNum);

int result = number*number;

Console.WriteLine(result);

}
