Dictionary<string, int> settings = new Dictionary<string, int>
{
    { "volume", 70 },
    { "brightness", 50 }
};

void AdjustBrightness(int level)
{
    int newSettings = level;
    return newSettings;
}

settings.brightness = AdjustBrightness(80)
