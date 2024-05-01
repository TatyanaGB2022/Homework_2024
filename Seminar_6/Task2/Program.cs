// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все 
// заглавные буквы заменены на строчные.
// Пример: “aBcD1ef!-” => “abcd1ef!-” 


void Main()
{
  System.Console.Write("Введите строку: "); 
  string? str = Console.ReadLine()?.ToLower(); 
  System.Console.WriteLine(str);
}

Main();