let totalScore = 0;

function addScore(points) {
    totalScore += points;
}
function printScore() {
    console.log("Total score is now: " + totalScore);
}

addScore(10);
printScore();
addScore(20);
printScore();
