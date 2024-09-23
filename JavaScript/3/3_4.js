let MAX_RETRIES = 3;
let ATTEMPT = 0;

while (ATTEMPT < MAX_RETRIES) {
    if (tryConnect()) {
        console.log("Connected successfully.");
        break;
    } else {
        console.log("Retrying connection...");
        ATTEMPT++;
    }
}
if (ATTEMPT === MAX_RETRIES) {
    console.log("Failed to connect after 3 attempts.");
}
