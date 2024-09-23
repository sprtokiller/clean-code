class P {
  constructor(n, a) {
      this.name = n;
      this.age = a;
  }

  d() {
      console.log(this.name + " is " + this.age + " years old.");
  }
}

let p = new P("Alice", 30);
p.d();
