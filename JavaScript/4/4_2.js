const settings = {
  volume: 70,
  brightness: 50
};
//Function to adjust the breghtness setting
function adjustBrightness(level) {
  settings.brightness = level;
  console.log("Brightness set to: " + settings.brightness);
}

adjustBrightness(80);
