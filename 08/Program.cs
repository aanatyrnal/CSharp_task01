Console.WriteLine("Введите число:");
int numberOne = int.Parse(Console.ReadLine());
for (int i = 2; i<= numberOne; i+=2)
{
    Console.Write(i + " ");
}
Console.WriteLine();