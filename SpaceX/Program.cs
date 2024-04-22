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

        IEnumerable<Launch> failures2 =
            from launch in launches
            where launch.success == false
            select launch;
        
        foreach (Launch launch in failures2)
        {
            Console.WriteLine($"{launch.name}\t\t{launch.date_utc.Year}\n" +
                              $"{launch.details}\n-----------------------------------");
        }
    }
}