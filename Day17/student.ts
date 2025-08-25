class Student {
    id: number;
    name: string;
    constructor(id: number, name: string) {
        this.id = id;
        this.name = name;
    }
    display(): void {
        console.log(`ID: ${this.id}, Name: ${this.name}`);
    }
}

let s1 = new Student(1, "Niranjan");
let s2 = new Student(2, "Himanshu");
s1.display();
s2.display();
