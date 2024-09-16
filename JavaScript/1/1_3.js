class Person {
  constructor(name, age) {
    this.name = name;
    this.age = age;
  }

  describe() {
    console.log(this.name + " is " + this.age + " years old.");
  }
}

let alice = new Person("Alice", 30);

alice.describe();
