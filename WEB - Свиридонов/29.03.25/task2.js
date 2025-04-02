let arrayDivider = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]; 
let divider = [];
let numForDivider = 100;

for(let i = 0; i < arrayDivider.length; i++)
{
    if(100 % arrayDivider[i] === 0)
    {
        divider.push(arrayDivider[i]);
    }
}

console.log(divider);