class Program
{
    static void Main()
    {
        DateTime birthDate;
        bool validInput = false;

        while (!validInput)
        {
            Console.Write("Enter your birthday date (MM-DD-YYYY): ");
            string input = Console.ReadLine();

            if (DateTime.TryParse(input, out birthDate))
            {
                int age = DateTime.Now.Year - birthDate.Year;
                if (birthDate > DateTime.Now.AddYears(-age)) age--;

                Console.WriteLine($"You are {age} years old.");
                validInput = true;
            }
            else
            {
                Console.WriteLine("Invalid date format. Please enter in MM-DD-YYYY format.");
            }
        }
    }
}