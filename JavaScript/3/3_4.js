const MAX_RETRIES = 3; 
const RETRY_MESSAGE = "Retrying connection...";
const FAILURE_MESSAGE = "Failed to connect after 3 attempts."; 

let attempt = 0; 
while (attempt < MAX_RETRIES) {
    if (tryConnect()) {
        console.log("Connected successfully.");
        break;
    } else {
        console.log(RETRY_MESSAGE);
        attempt++;
    }
}
if (attempt === MAX_RETRIES) {
    console.log(FAILURE_MESSAGE);
}