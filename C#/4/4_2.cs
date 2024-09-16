Dictionary<string, int> settings = new Dictionary<string, int>
{
    { "volume", 60 },
    { "brightness", 40 }
};

void AdjustBrightness(int level)
{
    settings["brightness"] = level;
    Console.WriteLine("Brightness set to: " + settings["brightness"]);
}

AdjustBrightness(80);
