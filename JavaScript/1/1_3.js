class P {
  constructor(name, age) {
      this.name = name;
      this.age = age;
  }

  d() {
      console.log(this.name + " is " + this.age + " years old.");
  }
}

let p = new P("Alice", 30);
p.d();
