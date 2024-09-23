let settings = {
  volume: 70,
  brightness: 50
};

function adjustBrightness(level) {
  settings.brightness = level;
}

adjustBrightness(80);
console.log("Brightness set to: " + settings.brightness);
