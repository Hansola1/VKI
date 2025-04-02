let _ = require('lodash');

let array = [1, 2, 3, 4, 5]; 

let result = _.flatMap(array, (num) => [num, num]);
console.log(result);
