
// вводим два числа
string? inputNum1 = Console.ReadLine();
string? inputNum2 = Console.ReadLine();

// проверяем на null
if (inputNum1 != null && inputNum2 != null)
{
    //    парсим 
    int number1 = int.Parse(inputNum1);

    int number2 = int.Parse(inputNum2);

    // проверяем какое число больше 
    if (number1 > number2)
    {
        Console.WriteLine("Первое чило больше второго");
    }
    else
    {
        Console.WriteLine("Второе число больше первого");
    }
}
