using _07._Raw_Data;

int n = int.Parse(Console.ReadLine());

List<Car> cars = new ();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();
    Car car = new(
        input[0],
        int.Parse(input[1]),
        int.Parse(input[2]),
        int.Parse(input[3]),
        input[4],
        double.Parse(input[5]),
        int.Parse(input[6]),
        double.Parse(input[7]),
        int.Parse(input[8]),
        double.Parse(input[9]),
        int.Parse(input[10]),
        double.Parse(input[11]),
        int.Parse(input[12])
        );

    cars.Add(car);
}

string command = Console.ReadLine();

string[] neededCars;

if (command =="fragile" )
{
    neededCars = cars
        .Where(c => c.Cargo.Type == "fragile" && c.Tire.Any(t => t.Pressure < 1))
        .Select(c=>c.Model).ToArray();
}
else
{
    neededCars = cars
            .Where(c => c.Cargo.Type == "flammable" && c.Engine.Power>250)
            .Select(c => c.Model).ToArray();
}

Console.WriteLine(String.Join(Environment.NewLine,neededCars));