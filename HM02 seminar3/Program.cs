//Найти кубы чисел от 1 до N
Console.WriteLine("Чтобы найти кубы чисел от 1 до N, введите число N");
int n = int.Parse(Console.ReadLine()?? "");

for (int num = 1; num <= n; num++)
{
    Console.WriteLine ($"{num} в кубе = {num * num * num}");
}