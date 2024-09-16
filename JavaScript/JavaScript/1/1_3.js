class constructorOfPerson {
  constructor(person, year) {
      this.person = person;
      this.year = this.year;
  }

  extractToConsole() {
      console.log(this.person + " is " + this.year + " years old.");
  }
}

let finalResult = new constructorOfPerson("Alice", 30);
finalResult.extractToConsole();
