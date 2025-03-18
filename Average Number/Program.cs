Console.Write("Enter the First number: ");
bool success1 = int.TryParse(Console.ReadLine(), out int num1);

Console.Write("Enter the Second number: ");
bool success2 = int.TryParse(Console.ReadLine(), out int num2);

Console.Write("Enter the Third number: ");
bool success3 = int.TryParse(Console.ReadLine(), out int num3);

Console.Write("Enter the Fourth number: ");
bool success4 = int.TryParse(Console.ReadLine(), out int num4);

if (success1 && success2 && success3 && success4)
{
    double average = (num1 + num2 + num3 + num4) / 4;
    Console.WriteLine($"The average of {num1}, {num2}, {num3} and {num4} is: {average}");
}
else
{
    Console.WriteLine("Invalid input! Please enter valid numbers.");
}