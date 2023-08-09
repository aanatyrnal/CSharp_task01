Console.WriteLine("Введите число:");
int numberOne = int.Parse(Console.ReadLine());
string answer;
if (numberOne %2 == 0) answer = "yes";
else answer = "no";
Console.WriteLine(answer);