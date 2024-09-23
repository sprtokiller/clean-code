const maxRetries = 3;

for (attempt = 0; attempt < maxRetries; attempt++) {
    if (tryConnect()) {
        console.log("Connected successfully.");
        break;
    } else {
        console.log("Retrying connection...");
    }
}
if (attempt === maxRetries) {
    console.log("Failed to connect after 3 attempts.");
}
