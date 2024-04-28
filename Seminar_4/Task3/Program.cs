// Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, 
// второй – предпоследним и т.д.)
// Пример:
// [1 3 5 6 7 8] => [8 7 6 5 3 1]


int[] GenerateArray(int len) 
{
  int[] array = new int[len];
  Random rnd = new Random();
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = rnd.Next(-9, 10);
  }
  return array;
}

int[] Reverse(int[] array) 
{
  for (int i = 0; i < array.Length / 2; i++) 
  {
    int temp = array[i];
    array[i] = array[array.Length - 1 - i];
    array[array.Length - 1 - i] = temp;
  }
  return array;
}

void PrintArray(int[] array)
{
  foreach (int item in array)
  {
    System.Console.Write($"{item}\t");
  }
  System.Console.WriteLine();
}
int[] array = GenerateArray(5);
PrintArray(array);
PrintArray(Reverse(array));