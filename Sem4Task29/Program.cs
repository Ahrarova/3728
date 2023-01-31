// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Генератор массива
int[] Gen1DArr(int num, int begin, int end)
{
    Random rnd = new Random();
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(begin, end);
    }
    return arr;
}
// вывод массива на экран
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length-1]+"]");
}

// пользователь вводит данные 
int arrLen = ReadData("Введите длину массива: ");
int FirstBorder = ReadData("Введите первую границу массива: ");
int SecondBorder = ReadData("Введите вторую границу массива: ");
// вызов метода генерации массива
int[] arr = Gen1DArr(arrLen, FirstBorder, SecondBorder);
// выводим массива на экран
Print1DArr(arr);