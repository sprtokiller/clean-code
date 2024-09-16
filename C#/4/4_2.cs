//Settings
Dictionary<string, int> settings = new Dictionary<string, int>
{
    { "volume", 70 },
    { "brightness", 50 }
};

//Brightness adjustment
void AdjustBrightness(int level)
{
    settings["brightness"] = level;
    Console.WriteLine("Brightness set to: " + settings["brightness"]);
}

AdjustBrightness(80);
