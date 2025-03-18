namespace CarRacing;

class Program
{
    static void RaceCars(Car car1, Car car2)
    {
        int speed1 = car1.CalculateSpeed();
        int speed2 = car2.CalculateSpeed();

        if (speed1 > speed2)
        {
            Console.WriteLine($"{car1.Model} driven by {car1.Driver.Name} won with a speed of {speed1}.");
        }
        else if (speed2 > speed1)
        {
            Console.WriteLine($"{car2.Model} driven by {car2.Driver.Name} won with a speed of {speed2}.");
        }
        else
        {
            Console.WriteLine("It was a tie!");
        }
    }

    static void Main()
    {
        List<Car> cars = new List<Car>
        {
            new Car("Hyundai", 120),
            new Car("Mazda", 150),
            new Car("Ferrari", 200),
            new Car("Porsche", 180)
        };

        List<Driver> drivers = new List<Driver>
        {
            new Driver("Bob", 3),
            new Driver("Greg", 5),
            new Driver("Jill", 4),
            new Driver("Anne", 2)
        };

        bool raceAgain;
        do
        {
            Console.WriteLine("Choose a car no.1:");
            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {cars[i].Model}");
            }
            int choice1 = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Choose a driver for car no.1:");
            for (int i = 0; i < drivers.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {drivers[i].Name}");
            }
            int driverChoice1 = int.Parse(Console.ReadLine()) - 1;

            Car car1 = cars[choice1];
            car1.Driver = drivers[driverChoice1];

            Console.WriteLine("Choose a car no.2:");
            for (int i = 0; i < cars.Count; i++)
            {
                if (i != choice1)
                {
                    Console.WriteLine($"{i + 1}. {cars[i].Model}");
                }
            }
            int choice2;
            do
            {
                choice2 = int.Parse(Console.ReadLine()) - 1;
            } while (choice2 == choice1);

            Console.WriteLine("Choose a driver for car no.2:");
            for (int i = 0; i < drivers.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {drivers[i].Name}");
            }
            int driverChoice2 = int.Parse(Console.ReadLine()) - 1;

            Car car2 = cars[choice2];
            car2.Driver = drivers[driverChoice2];

            RaceCars(car1, car2);

            Console.WriteLine("Do you want to race again? (yes/no)");
            raceAgain = Console.ReadLine().ToLower() == "yes";
        }
        while (raceAgain);
    }
}