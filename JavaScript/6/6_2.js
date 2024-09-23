if (grade >= 90) {
  console.log("Grade: A");
  congratulateStudent();
  updateRecords();
} else if (grade >= 80) {
  console.log("Grade: B");
  congratulateStudent();
  updateRecords();
} else if (grade >= 70) {
  console.log("Grade: C");
  updateRecords();
} else if (grade >= 60) {
  console.log("Grade: D");
  updateRecords();
} else {
  console.log("Grade: F");
  updateRecords();
}
function handleGrade(grade) {
  let gradeLetter;

  if (grade >= 90) {
    gradeLetter = "A";
    congratulateStudent();
  } else if (grade >= 80) {
    gradeLetter = "B";
    congratulateStudent();
  } else if (grade >= 70) {
    gradeLetter = "C";
  } else if (grade >= 60) {
    gradeLetter = "D";
  } else {
    gradeLetter = "F";
  }

  console.log("Grade: " + gradeLetter);
  updateRecords();
}

handleGrade(grade);
