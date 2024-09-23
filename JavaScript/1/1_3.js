class Human {
  constructor(name, age) {
      this.name = name;
      this.age = age;
  }

  info() {
      console.log(this.name + " is " + this.age + " years old.");
  }
}

let Human1 = new Human("Alice", 30);
Human1.info();
