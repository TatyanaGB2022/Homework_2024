// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

void Main()
{
  char[] chars = { 'a', 'b', 'c', 'd', 'e', 'f' };
  string str = ArrayToString(chars);
  System.Console.WriteLine(str);

}

string ArrayToString(char[] chars)
{
  string str = "";
  foreach (char letter in chars)
    str += letter;
  return str;
}

Main();