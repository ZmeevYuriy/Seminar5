//Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
int n, sum1 = 0, sum2 = 0;
Random rand = new Random();
int[] a;
Console.Write("Введите размер массива: ");
n = int.Parse(Console.ReadLine());
a = new int [n];

Console.WriteLine("Исходный массив:");
for (int i = 0; i < n; i++)
{
    a[i] = rand.Next(-10,10);
}
string inputString = string.Join(",",a);
PrintArray(a);

for (int i = 0; i < n; i++)
{
    if (i % 2 == 0)
    sum1 = sum1 + a[i];
    else
    sum2 = sum2 + a[i];
}

void PrintArray(int[] arrayB)
{
  Console.Write("[");
  int lenght1 = arrayB.Length;
  int i1 = 0;
  while(i1 < (lenght1 - 1))
  {
      Console.Write(arrayB[i1] + ",");
      i1++;
  }
  Console.Write(arrayB[lenght1 - 1] + "]");
}

Console.WriteLine("Сумма элементов с нечетными позициями : {0} ", sum2);

// Надеюсь решение верное. Но все же думаю, что есть другой способ, но пока я его не нашел.
// Получилось только так.