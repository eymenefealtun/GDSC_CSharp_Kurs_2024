Console.WriteLine("ARITHMETIC OPERATORS");

decimal number1 = 67.3M;
decimal number2 = 29.23M;

Console.WriteLine($"{number1} + {number2} = {number1 + number2}");

Console.WriteLine($"{number1} - {number2} = {number1 - number2}");

Console.WriteLine($"{number1} / {number2} = {number1 / number2}");

Console.WriteLine($"{number1} * {number2} = {number1 * number2}");

Console.WriteLine($"{number1} BOLU {number2}'den kalan = {number1 % number2}");

Console.WriteLine("LOGICAL OPERATORS");

bool condition1 = true;
bool condition2 = false;

Console.WriteLine($"{condition1} AND {condition2} = {condition1 && condition2}");

Console.WriteLine($"{condition1} OR {condition2} = {condition1 || condition2}");


Console.WriteLine($"NOT{condition1} OR {condition2} = {!condition1 || condition2}");

Console.WriteLine("COMPRASION OPERATORS");

string city1 = "Izmır";
string city2 = "Adana";

Console.WriteLine(city1 == city2);
Console.WriteLine(city1 != city2);
Console.WriteLine(city1.Length <= city2.Length);

Console.ReadLine();