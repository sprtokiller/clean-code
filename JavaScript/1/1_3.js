class Person {
	constructor(name, age) {
		this.name = name;
		this.age = age;
	}

	PrintData() {
		console.log(`${this.name} is ${this.age} years old.`);
	}
}

let testPerson = new Person("Alice", 30);
testPerson.PrintData();
