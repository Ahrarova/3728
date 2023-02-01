//  Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// [845, 222, 367, 123] -> 1

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

// метод подсчета количества четных чисел в массиве
int CountElem(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (Test(arr[i]))
        {
            res++;
        }
    }
    return res;
}
// метод в методе. проверяет на четность
bool Test(int n)
{
    return (n % 2 == 0);
}

// вызваем методы: генерация массива, вывод массива на экран, подсчет четных чисел и вывод результата
int[] testArr = Gen1DArray(123, 100, 999);
Print1DArr(testArr);
int count = CountElem(testArr);
PrintData("Количество чётных чисел :" + count);