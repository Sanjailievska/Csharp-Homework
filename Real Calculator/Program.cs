Console.WriteLine("Enter the First number: ");
string firstInput = Console.ReadLine();
bool firstSuccess = double.TryParse(firstInput, out double num1);

Console.WriteLine("Enter the Second number: ");
string secondInput = Console.ReadLine();
bool secondSuccess = double.TryParse(secondInput, out double num2);

if (!firstSuccess || !secondSuccess)
{
    Console.WriteLine("Error: Invalid number input.");
    return;
}

Console.WriteLine("Enter the Operation (+, -, *, /): ");
string operationInput = Console.ReadLine();
char operation = operationInput.Length > 0 ? operationInput[0] : ' ';

double result = 0;
bool validOperation = true;

switch (operation)
{
    case '+':
        result = num1 + num2;
        break;
    case '-':
        result = num1 - num2;
        break;
    case '*':
        result = num1 * num2;
        break;
    case '/':
        if (num2 != 0)
            result = num1 / num2;
        else
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            validOperation = false;
        }
        break;
    default:
        Console.WriteLine("Error: Invalid operation.");
        validOperation = false;
        break;
}
if (validOperation)
    Console.WriteLine("The result is: " + result);