namespace SpaceX;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, SpaceX!");

        IEnumerable<Launch> launches = SpaceXLoader.LoadData();

        IEnumerable<Launch> failures =
            launches
                .Where(l => l.success == false);

        foreach (Launch launch in launches)
        {
            Console.WriteLine($"{launch.name}\t\t{launch.date_utc.Year}\n" +
                              $"{launch.details}\n-----------------------------------");
        }
    }
}