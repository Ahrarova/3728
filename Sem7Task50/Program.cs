// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив: 
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// 17 -> такого числа в массиве нет

// метод принимает данные от пользователя
int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// метод генерации 2мерного массива
int[,] Gen2DArr(int countRow, int countColumn)
{
    System.Random numberSyntezator = new System.Random();
    int i = 0; int j = 0;
    int[,] outArray = new int[countRow, countColumn];
    while (i < countRow)
    {
        j = 0;
        while (j < countColumn)
        {
            outArray[i, j] = numberSyntezator.Next(0, 101);
            j++;
        }
        i++;
    }
    return outArray;
}

// метод печати сгенерированного массива
void Print2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine("");
    }
}

// метод поиска элемента
void SerchElem(int[,] arr, int elem)
{
    bool elemFind = false;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (elem == arr[i, j])
            {
                Console.WriteLine("элемент " + elem + " найден на позиции " + "[" + i + "," + j + "]");
                elemFind = true;
            }
        }

    }
    if (elemFind == false)
    {
        Console.WriteLine("элемент не найден");
    }
}

// получаем данные пользователя
int xlen = InputNum("Введите число столбцов: ");
int ylen = InputNum("Введите число строк: ");
int el = InputNum("Введите искомый элемент: ");
// вызываем метод генерации массива
int[,] matrix = Gen2DArr(xlen, ylen);
// вызываем метод печати массива
Print2DArr(matrix);
// вызываем метод поиска элемента 
SerchElem(matrix, el);
