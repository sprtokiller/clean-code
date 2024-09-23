function addScore(currentScore, points) {
    const newScore = currentScore + points;
    console.log("Total score is now: " + newScore);
    return newScore;
}


let totalScore = 0;
totalScore = addScore(totalScore, 10); //add 10 points 
totalScore = addScore(totalScore, 20); //add 20 points
