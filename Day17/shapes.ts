interface Shape {
    area(): number;
}

class Circle implements Shape {
    radius: number;
    constructor(radius: number) { this.radius = radius; }
    area(): number { return Math.PI * this.radius * this.radius; }
}

class Square implements Shape {
    side: number;
    constructor(side: number) { this.side = side; }
    area(): number { return this.side * this.side; }
}

let c = new Circle(5);
let s = new Square(4);
console.log("Circle Area:", c.area());
console.log("Square Area:", s.area());
