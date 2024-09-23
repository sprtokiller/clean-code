let totalScore = 0;

function addScore(currentScore, points) {
    let newScore = currentScore + points;
    console.log("Total score is now: " + newScore);
}

totalScore = addScore(totalScore,10);
totalScore = addScore(totalScore,20);
