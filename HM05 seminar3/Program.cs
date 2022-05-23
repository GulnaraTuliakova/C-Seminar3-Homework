//Подсчитать сумму цифр в числе
Console.WriteLine("Чтобы подсчитать сумму цифр в числе, введите число A");
int number = int.Parse(Console.ReadLine()?? "");
int sum = 0;
while (number > 0)
   {
   sum = sum + number % 10;
   number = number / 10;
   }
    Console.WriteLine (sum);

   
   
   /* Console.WriteLine("Чтобы подсчитать сумму цифр в числе, введите число A");
string number = Console.ReadLine()?? "";
int length = number.Length;
int sum = 0;
for (int i = 0; i < length; i++)
   {
   sum = sum + number[i];
    }
    Console.WriteLine (sum);*/