//Найти сумму чисел от 1 до А

Console.WriteLine("Чтобы найти сумму чисел от 1 до A, введите число A");
int a = int.Parse(Console.ReadLine()?? "");
int sum = 0;
for (int num = 1; num <= a; num++)
{
   sum = sum + num;
  }
  Console.WriteLine ($" Сумма чисел от 1 до {a} равна {sum}");
