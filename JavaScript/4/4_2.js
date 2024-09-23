let settings = {
  volume: 70,
  brightness: 50
};

function adjustBrightness(level) {
  let brightnessLevel = settings.brightness = level;
  console.log("Brightness set to: " + brightnessLevel);
}

adjustBrightness(80);
