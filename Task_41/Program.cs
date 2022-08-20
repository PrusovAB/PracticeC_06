Console.Write("Введите числа через пробел: ");
// Преобразуем полученное строчное значение в массив через пробел.
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int SumPositiveNumber(int[] array)
{
   int sum = 0;
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i] > 0)
      {
         sum++;
      }
   }
   return sum;
}

int sumPositiveNumber = SumPositiveNumber(arr);
Console.WriteLine($"сумма положительный чисел введеных пользователем  = {sumPositiveNumber}");
