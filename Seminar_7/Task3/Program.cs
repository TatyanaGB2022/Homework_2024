// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.
// Пример: [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

void Main()
{
  int[] num = { 1, 2, 5, 0, 10, 34 };
  PrintArray(num, num.Length - 1);
}

void PrintArray(int[] A, int n)
{
  if (n > 0)
  {
    System.Console.Write(A[n] + " ");
    PrintArray(A, n - 1);
  }

  else
    System.Console.WriteLine(A[0]);
}

Main();

