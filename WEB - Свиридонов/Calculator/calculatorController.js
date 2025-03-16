function addData(number) 
{
    let textBox = document.getElementById('textBox');
    textBox.value += number;
}

function clear() 
{
    let textBox = document.getElementById('textBox');
    textBox.value = textBox.value.slice(0, -1);
}

function calculate() 
{
    let textBox = document.getElementById('textBox');
    textBox.value = eval(textBox.value);
}