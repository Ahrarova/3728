// Напишите программу, которая будет выдавать название дня недели
// по заданному номеру. Например 3-среда, 5-пятница.

string? inputNum = Console.ReadLine();

if(inputNum!=null)
{

string[]dayWeek = new string [7];
dayWeek[0] = "понедельник";
dayWeek[1] = "вторник";
dayWeek[2] = "среда";
dayWeek[3] = "четверг";
dayWeek[4] = "пятница";
dayWeek[5] = "суббота";
dayWeek[6] = "воскресенье";

int nameDay = int.Parse(inputNum);

string outdayWeek = dayWeek[nameDay-1];

Console.WriteLine(outdayWeek);
}


