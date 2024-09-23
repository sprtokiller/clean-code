Dictionary<string, int> settings = new Dictionary<string, int>
{
    { "volume", 70 },
    { "brightness", 50 }
};

int AdjustBrightness(string name, int level)
{
    return name = level;
    
}


AdjustBrightness(settings["brightness"], 80);
Console.WriteLine("Brightness set to: " + settings["brightness"]);