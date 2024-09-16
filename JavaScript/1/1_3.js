class Person {
  constructor(name, age) {
      this.name = name;
      this.age = age;
  }

  data() {
      console.log(this.name + " is " + this.age + " years old.");
  }
}

let person = new Person("Alice", 30);
person.data();
