int[] numbers = new int[6];

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine("Enter integer no.: " + (i + 1));
    bool success = int.TryParse(Console.ReadLine(), out numbers[i]);
    if (!success)
    {
        Console.WriteLine("Invalid input! Setting value to 0.");
        numbers[i] = 0;
    }
}

int sum = 0;
foreach (int num in numbers)
{
    if (num % 2 == 0)
    {
        sum += num;
    }
}

Console.WriteLine("The result is: " + sum);