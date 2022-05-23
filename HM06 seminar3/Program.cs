//Показать кубы чисел, заканчивающихся на четную цифру
Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());
if (num % 2 == 0)
{
    Console.WriteLine($"Куб четного числа {num} равен {num*num*num}");
}
else
{
Console.WriteLine("Введите другое число");
}