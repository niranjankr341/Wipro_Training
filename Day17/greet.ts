function greet(name: string, age?: number, country: string = "India") {
    if (age) {
        console.log(`Hello ${name}, Age: ${age}, Country: ${country}`);
    } else {
        console.log(`Hello ${name}, Country: ${country}`);
    }
}

greet("Niranjan");
greet("Himanshu", 22);
greet("Ravi", 25, "USA");
