
// вводим три числа
string? inputNum1 = Console.ReadLine();
string? inputNum2 = Console.ReadLine();
string? inputNum3 = Console.ReadLine();

// проверяем на null
if (inputNum1 != null && inputNum2 != null && inputNum3 != null)
{
    //    парсим 
    int number1 = int.Parse(inputNum1);
    int number2 = int.Parse(inputNum2);
    int number3 = int.Parse(inputNum3);

// Проверяем какое число больше
    if (number1 > number2)
    {
        if (number1 > number3)
        {
            Console.WriteLine(number1);
        }
        else
        {
            Console.WriteLine(number3);
        }
    }
    else
    {
        if (number2 > number3)
        {
            Console.WriteLine(number2);
        }
        else
        {
            Console.WriteLine(number3);
        }
    }


}
