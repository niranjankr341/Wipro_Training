// calculator.js
exports.add = (a,b)=>a+b;
exports.mul = (a,b)=>a*b;

// app.js
const calc = require('./calculator');
console.log("Sum:", calc.add(5,3));
console.log("Multiply:", calc.mul(5,3));
