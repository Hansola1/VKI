let { concat } = require('lodash');

let numOne = 10;
let numTwo = 10;

let arrayOne = [];
for (let i = 0; i < numOne; i++) 
{
  arrayOne.push(i);
}

let arrayTwo = [];
for (let i = 0; i < numTwo; i++) 
{
  arrayTwo.push(i);
}

let arrayResult = concat(arrayOne, arrayTwo);
console.log(arrayResult)