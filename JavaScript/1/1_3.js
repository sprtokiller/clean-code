//Class Person with name and age
class Person {
  constructor(name, age) {
      this.name = name;
      this.age = age;
  }

  displayAge() {
      console.log(`${this.name} is ${this.age} years old.`);
  }
}
//Create a instace from the Person class
const alice = new Person("Alice", 30);
alice.displayAge();
