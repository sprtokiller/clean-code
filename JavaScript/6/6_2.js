function getGrade(grade) {
  if (grade >= 90) return "A";
  else if (grade >= 80) return "B";
  else if (grade >= 70) return "C";
  else if (grade >= 60) return "D";
  else return "F";
}

let gradeLabel = getGrade(grade);
console.log("Grade: " + gradeLabel);
congratulateStudent();
updateRecords();
