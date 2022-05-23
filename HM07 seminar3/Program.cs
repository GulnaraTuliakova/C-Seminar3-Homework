//Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
void FillArray (int[] collection)
{
    int length = collection.Length;
    for (int i = 0; i < length; i++)
    {
        collection[i] = new Random().Next(0,2);
    }
}
void PrintArray (int[] coll)
{
    int lengthColl = coll.Length;
    for (int pos = 0; pos < lengthColl; pos++)
    {
      Console.Write(coll[pos] + " ");  
    }
}
int [] array = new int[8];
FillArray (array);
PrintArray (array);
Console.WriteLine();

