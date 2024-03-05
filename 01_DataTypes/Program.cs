Console.WriteLine("Hello World!");


// DATA TYPES


// INTEGER -  32 bit

int number1 = -2147483648;
Console.WriteLine(number1);



// LONG - 64 bitlik

long number2 = 9223372036854775807;


// SHORT - 16 bit yer tutar
short number3 = -32768;
Console.WriteLine(number3.GetType());


// BYTE -8 bit yer kaplar
byte number4 = 255;
Console.WriteLine(number4.GetType());


// DOUBLE
double number5 = 12.34244243434546679789789222;
Console.WriteLine($"My double variable = {number5}. Its type is {number5.GetType()}");

// DECIMAL
decimal number6 = 12.34244243434546679789789222M;
Console.WriteLine($"My decimal variable = {number6}. Its type is {number6.GetType()}");

// CHAR
char character = 'İ';
Console.WriteLine(character);
Console.WriteLine((int)character);


// VAR
var myVariable = 32.3;
Console.WriteLine(myVariable.GetType());


// BOOLEAN
bool condition1 = false;
bool condition2 = true;
Console.WriteLine(condition1.GetType());



Console.ReadLine();