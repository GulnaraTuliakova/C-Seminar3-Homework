//Показать таблицу квадратов чисел от 1 до N
Console.WriteLine("Чтобы показать таблицу квадратов чисел от 1 до N, введите число N");
int n = int.Parse(Console.ReadLine()?? "");

for (int num = 1; num <= n; num++)
{
    Console.WriteLine ($"{num} в квадрате равен {num * num}");
}