function getArray<T>(items: T[]): T[] {
    return new Array<T>().concat(items);
}

let numArray = getArray<number>([1, 2, 3, 4]);
let strArray = getArray<string>(["Apple", "Banana", "Mango"]);

console.log("Numbers:", numArray);
console.log("Strings:", strArray);
