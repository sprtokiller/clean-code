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
}
