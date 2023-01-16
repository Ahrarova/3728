
string? inputNum = Console.ReadLine();

if(inputNum!=null)
{
    int numbers = int.Parse(inputNum);

string numberLine = string.Empty;

for(int i = 2; i<numbers; i = i+2)
{
 numberLine = numberLine + i + ",";   
}

if (numbers%2==0)
{
    numberLine=numberLine+1;
}
Console.WriteLine(numberLine);
}
