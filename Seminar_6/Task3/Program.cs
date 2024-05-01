// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.
// Пример:
// “aBcD1ef!-” => Нет
// “шалаш” => Да
// “55655” => Да


Console.Write("Введите строку : ");
String str = Console.ReadLine();
char[] chars = str.ToCharArray();
{
if (IsPalindrom(chars))
  Console.WriteLine("Палиндром");
else
  Console.WriteLine("Не палиндром");
        }
        static bool IsPalindrom(char[] word)
{
  for (int i = 0; i < word.Length / 2; i++)
    if (word[i] != word[word.Length - 1 - i])
      return false;
  return true;
}
    