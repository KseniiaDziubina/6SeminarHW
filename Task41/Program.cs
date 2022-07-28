Console.WriteLine("Введите числа через пробел  ");

int[] myArray = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

int count = 0;

for (int i = 0; i < myArray.Length; i++)
{
       if (myArray[i]> 0)
       {
           count++;
       }
}
Console.WriteLine($"Количество введённых чисел больше 0: {count}");
