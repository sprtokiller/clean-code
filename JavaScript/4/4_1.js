function calculateNewScore(currentScore, points) {
    return currentScore + points; 
}

let currentScore = 0;
let newScore = calculateNewScore(currentScore, 10);
console.log("New score: " + newScore); 