namespace LearningLINQ.Filteration;

public static class CarRepository
{

    public static IEnumerable<Car> GetCars()
    {
        List<Car> cars = new List<Car>
        {
            new Car(1, "Toyota", "Corolla", 2020, "JTDBU4EE9A9123456", "White", 180),
            new Car(2, "Honda", "Civic", 2019, "2HGFC2F59KH512345", "Black", 200),
            new Car(3, "Ford", "Mustang", 2022, "1FA6P8TH3N5123456", "Red", 250),
            new Car(4, "Chevrolet", "Camaro", 2021, "1G1FB1RS3M0123456", "Yellow", 240),
            new Car(5, "Tesla", "Model 3", 2023, "5YJ3E1EA7MF123456", "Blue", 260),
            new Car(6, "BMW", "X5", 2020, "5UXCR4C56L9D12345", "Silver", 230),
            new Car(7, "Mercedes-Benz", "C-Class", 2018, "WDDZF4KBXKA512345", "Gray", 220),
            new Car(8, "Audi", "A4", 2021, "WAUENAF49MA123456", "Black", 210)
        };
        return cars;
    }
    public static void PrintCars(IEnumerable<Car> cars)
    {
        Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────┐");
        Console.WriteLine("│                                Car List                                  │");
        Console.WriteLine("├────┬─────────────────┬───────────┬─────────────┬───────────────────┬─────┤");
        Console.WriteLine("│ Id │ Make            │ Model     │ Year        │ VIN               │ Max │");
        Console.WriteLine("│    │                 │           │             │                   │ Spd │");
        Console.WriteLine("├────┼─────────────────┼───────────┼─────────────┼───────────────────┼─────┤");

        foreach (var car in cars)
        {
            Console.WriteLine($"│ {car.Id,-2} │ {car.Make,-15} │ {car.Model,-9} │ {car.ManufactureYear,-11} │ {car.VIN,-15} │ {car.MaxSpeed,3} │");
        }

        Console.WriteLine("└────┴─────────────────┴───────────┴─────────────┴───────────────────┴─────┘");

        Console.WriteLine($"Count: {cars.Count()}");
    }
}