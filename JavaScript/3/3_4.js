


const MAXRETRIES = 3;
const ATTEMPT = 0;


while (ATTEMPT < MAXRETRIES) {
    if (tryConnect()) {
        console.log("Connected successfully.");
        break;
    } else {
        console.log("Retrying connection...");
        ATTEMPT++;
    }
}
if (ATTEMPT === MAXRETRIES) {
    console.log("Failed to connect after 3 ATTEMPTs.");
}
