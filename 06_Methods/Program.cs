void Show()
{
    Console.WriteLine("Showed!");
}

Show();


int Add(int number1, int number2)
{
    int result = number1 + number2;
    return result;
}

int myResult = Add(32, 56);

Console.WriteLine(myResult);


int Add2(int number1, int number2 = 99)
{
    int result = number1 + number2;
    return result;
}

int myResult2 = Add2(32);

Console.WriteLine(myResult2);


int Add3(ref int number1, int number2)
{
    number1 = 88;
    return number1 + number2;
}
int myNum1 = 12;
int myNum2 = 36;
Console.WriteLine($"My number: {myNum1}");
int myResult3 = Add3(ref myNum1, myNum2);
Console.WriteLine(myResult3);
Console.WriteLine($"My number: {myNum1}");




int Add4(params int[] numbers)
{
    return numbers.Sum();
}
Console.WriteLine(Add4(12, 34, 2, 9, 75, 67));


Console.ReadLine();

