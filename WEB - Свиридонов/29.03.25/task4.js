let num = String(103030000030303030);

let position = [];
for (let i = 1; i < num.length - 1; i++) 
{
    if (num[i] === '3') 
    { 
        position.push(i);
    }
}
console.log(position);