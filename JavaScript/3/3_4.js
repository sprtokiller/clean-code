const MAX_RETRIES = 3;
const ATTEMPT = 0;
//Connected, because you used less than 3 tries
while (attempt < MAX_RETRIES) {
    if (tryConnect()) {
        console.log("Connected successfully.");
        break;
    } else {
        console.log("Retrying connection...");
        attempt++;
    }
}
//Failed to connect, because you reach max attempts
if (attempt === MAX_RETRIES) {
    console.log("Failed to connect after 3 attempts.");
}
