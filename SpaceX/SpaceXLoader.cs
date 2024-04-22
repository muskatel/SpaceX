using Newtonsoft.Json;

namespace SpaceX;

public static class SpaceXLoader
{
    private static String file = "launches.json";
    public static IEnumerable<Launch> LoadData()
    {
        StreamReader sr = new StreamReader(file);
        
        // load characters from json file
        IEnumerable<Launch> launches= JsonConvert
            .DeserializeObject<IEnumerable<Launch>>(sr.ReadToEnd());
        sr.Close();

        return launches;
    }
}