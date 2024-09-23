let settings = {
  volume: 70,
  brightness: 50
};

function adjustBrightness(level) {
  let newBrightness = level;
  settings.brightness = newBrightness;
  console.log("Brightness set to: " + newBrightness);
}

adjustBrightness(80);
