let settings = {
  volume: 70,
  brightness: 50
};

function adjustBrightness(level) {
  let brightnesslevel = settings.brightness = level;
  console.log("Brightness set to: " + brightnesslevel);
}

adjustBrightness(80);
