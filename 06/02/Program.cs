Console.WriteLine("Введите 1 число:");
int numberOne = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 2 число:");
int numberTwo = int.Parse(Console.ReadLine());
int max = numberOne;
if (numberTwo > max) max = numberTwo;
Console.Write("max = ");
Console.WriteLine(max);