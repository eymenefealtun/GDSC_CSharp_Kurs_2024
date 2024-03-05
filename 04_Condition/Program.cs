decimal input = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"You have just written {input}");

if (input < 0)
{
    Console.WriteLine("The number is negative!");
}
else if (input > 0)
{
    Console.WriteLine("The number is positive!");
}
else
{
    Console.WriteLine("The number is ZERO!");
}




    Console.ReadLine();