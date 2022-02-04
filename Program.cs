// Task13: Выяснить, кратно ли число заданному, если нет, вывести остаток.

int startNumber = 10;

Console.Write("Введите число ");
string checkNumber = Console.ReadLine();
int intNumber = Convert.ToInt16(checkNumber);

if (intNumber % startNumber != 0) 
Console.WriteLine("Остаток от деления " + checkNumber + " на " + startNumber + " равен " + intNumber % startNumber);
