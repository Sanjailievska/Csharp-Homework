Console.WriteLine("Student Group");

string[] studentsG1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
string[] studentsG2 = { "Ana", "Elena", "Marko", "Ivan", "Simona" };

Console.WriteLine("Enter student group: (there are 1 and 2)");
string input = Console.ReadLine();

if (input == "1")
{
    Console.WriteLine("The Students in G1 are:");
    foreach (string student in studentsG1)
    {
        Console.WriteLine(student);
    }
}
else if (input == "2")
{
    Console.WriteLine("The Students in G2 are:");
    foreach (string student in studentsG2)
    {
        Console.WriteLine(student);
    }
}
else
{
    Console.WriteLine("Invalid input. Please enter either 1 or 2.");
}