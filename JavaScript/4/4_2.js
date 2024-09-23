
let settings = {
  volume: 70,
  brightness: 50
};

function adjustBrightness(currentSettings, level) {
  const newSettings = {currentSettings, brightness: level };
  console.log("Brightness set to: " + newSettings.brightness);
  return newSettings;
}

settings = adjustBrightness(settings, 80); //brightness set to 80 
