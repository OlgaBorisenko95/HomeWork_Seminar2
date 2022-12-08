Console.Clear();

Console.WriteLine("Введите число 1: ");
int a = int.Parse(Console.ReadLine());

int b = (a%10);
if (a<100) 
{
    Console.WriteLine("Третьей цифры нет");  
}
else

    Console.WriteLine($"Третья цифра {b}");
