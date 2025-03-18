Console.WriteLine("Enter the first number:");
string firstInput = Console.ReadLine();

Console.WriteLine("Enter the second number:");
string secondInput = Console.ReadLine();

bool firstSuccess = int.TryParse(firstInput, out int firstNumber);
bool secondSuccess = int.TryParse(secondInput, out int secondNumber);

if (firstSuccess && secondSuccess)
{
    int temp = firstNumber;
    firstNumber = secondNumber;
    secondNumber = temp;

    Console.WriteLine("After Swapping:");
    Console.WriteLine("First Number: " + firstNumber);
    Console.WriteLine("Second Number: " + secondNumber);
}
else
{
    Console.WriteLine("Invalid input! Please enter numbers only.");
}