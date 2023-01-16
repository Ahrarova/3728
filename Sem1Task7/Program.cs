string? inputNum = Console.ReadLine();
if (inputNum != null)
{
    int inputNumA = int.Parse(inputNum);

    int lastDigit = inputNumA % 10;

    Console.WriteLine(lastDigit);
}