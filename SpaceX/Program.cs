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

        int launch2011 =
            launches
                .Where(l => l.date_utc.Year == 2011)
                .Count();
        
        Console.WriteLine("Launches in 2011: "+ launch2011);


        var successPerYear =
            launches
                //.Where(l => l.success == true)
                .GroupBy(l => l.date_utc.Year)
                .Select(lg => new
                {
                    Year = lg.Key,
                    SuccessfulLaunches = lg.Count(l => l.success==true)
                });

        int i = 0;

        // foreach (Launch launch in failures)
        // {
        //     Console.WriteLine($"{launch.name}\t\t{launch.date_utc.Year}\n" +
        //                       $"{launch.details}\n-----------------------------------");
        // }
    }
}