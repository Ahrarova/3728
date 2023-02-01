// Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3 7 22 2 78] -> 76
// [2 0,4 9 7,2 78] -> 77,6

// метод выводит на экран результат
void PrintData(string res)
{
    Console.WriteLine(res);
}
// метод генерации массива
double[] Gen1DArray(int len, int minValue, int maxValue)
{
    double[] arr = new double[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}
// метод вывода на экран сгенерированного массива
void Print1DArr(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}
// метод ищет разницу макс. и мин. элементов массива
double MinMax(double[] arr)
{
    double max = int.MinValue;
    double min = int.MaxValue;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    return (max - min);
}
// вызваем методы: генерация массива, вывод массива на экран, подсчет разницы элементов и вывод результата
double[] testArr = Gen1DArray(7, 1, 8);
Print1DArr(testArr);
double count = MinMax(testArr);
PrintData("разница max и min :" + count);
