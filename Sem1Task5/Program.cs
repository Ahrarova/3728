string? inputNum = Console.ReadLine();

if(inputNum!=null)
{
    int inputNumA = int.Parse(inputNum);

    int inputNumC = inputNumA*(-1);

string outNum = string.Empty;

while(inputNumC<inputNumA)
{
    outNum = outNum + inputNumC + ",";
    inputNumC = inputNumC + 1;
}
outNum = outNum + inputNumA;
Console.WriteLine(outNum);
}
