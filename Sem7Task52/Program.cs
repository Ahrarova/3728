// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом 
// столбце.
// Например, задан массив: 
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

// метод считает среднее арифметическое каждого столбца (принимает на вход 2мерный массив, возвращает 1мерный)
int[] MeanColum(int[,] arr)
{
    int[] means = new int[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            means[i]+=arr[i,j];
        }
        means[i]=means[i]/arr.GetLength(0);
    }
    return means;
}

// метод печатает 1мерный массив, который получился в методе MeanColum
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

// получаем данные от пользователя
int xlen = InputNum("Введите число столбцов: ");
int ylen = InputNum("Введите число строк: ");
// вызываем метод генерации массива
int[,] matrix = Gen2DArr(xlen, ylen);
// печатаем 2мерный массив
Print2DArr(matrix);
// печатаем результат - 1мерный массив
Print1DArr(MeanColum(matrix));

