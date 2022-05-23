//Возведите число А в натуральную степень B используя цикл
Console.WriteLine("Чтобы число А возвести в натуральную степень В, необходимо ввести числа");
Console.WriteLine("Введите число А:");
int a = int.Parse(Console.ReadLine()?? "");
Console.WriteLine("Введите натуральное число В:");
int b = int.Parse(Console.ReadLine()?? "");
if (b <= 0)
Console.WriteLine ("Ошибка! Введите натуральное число");
else
{
int exp = a;
for (int num = 1; num < b; num++)
{
   exp = exp * a;
  }
  Console.WriteLine ($"При взведении числа {a} в степень {b} получается {exp}");
}