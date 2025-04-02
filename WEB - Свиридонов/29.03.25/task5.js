let array = [1, 234, 21, 3, 200, 10, 3, 2, 7, 30];
let arrayNew = [];

for(let i = 0; i < array.length; i++)
{
    if(array[i] > 10)
    {
        arrayNew.push(array[i]);
    }
}
console.log(arrayNew);