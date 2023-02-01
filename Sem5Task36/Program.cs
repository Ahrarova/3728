// Задайте одномерный массив, заполненный случайными числами. Найдите сумму 
// элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19 
// [3, 7, -2, 1] -> 8
// [-4, -6, 89, 6] -> 0

// метод выводит на экран результат
void PrintData(string res)
{
    Console.WriteLine(res);
}
// метод генерации массива
int[] Gen1DArray(int len, int minValue, int maxValue)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}
// метод вывода на экран сгенерированного массива
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}
// метод ищет сумму элементов, стоящих на нечетных позициях
int SumPos(int[] arr)
{
    int res = 0;
    for (int i = 1; i < arr.Length; i = i + 2)
    {
        res += arr[i];
    }
    return res;
}
// вызваем методы: генерация массива, вывод массива на экран, подсчет суммы элементов и вывод результата
int[] testArr = Gen1DArray(123, 100, 999);
Print1DArr(testArr);
int count = SumPos(testArr);
PrintData("сумма элементов :" + count);