class Person {
  constructor(name, age) {
      this.name = name;
      this.age = age;
  }
  info() {
      console.log(this.name + " is " + this.age + " years old.");
  }
}
let Person1 = new Person("Alice", 30);
Person1.info();