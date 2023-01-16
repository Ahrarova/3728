
// вводим число
string? inputNum = Console.ReadLine();
// проверяем на null
if (inputNum != null)
{
    // парсим
    int num = int.Parse(inputNum);

// проверяем на чётность
    if ( num % 2 == 0 ) 
    {
        Console.WriteLine("число является чётным");
    }
    else
    {
        Console.WriteLine("число не является чётным");
    }
}

