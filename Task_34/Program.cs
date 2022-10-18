// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[N];

FillArrayRandomNumbers(numbers);
Console.WriteLine("Исходный массив: ");
string inputString = string.Join(",",numbers);
PrintArray(numbers);

int count = 0;
for (int array = 0; array < numbers.Length; array++)
if (numbers[array] % 2 == 0)
count++;

Console.WriteLine($"-> всего {numbers.Length} чисел, {count} из них чётные");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
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

