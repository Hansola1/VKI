const express = require('express');
const cors = require('cors');
const bodyParser = require('body-parser');

const app = express();
app.use(cors())
app.use(bodyParser.json())

app.post('/login', (request, response) => {
    console.log(request)
})

app.listen(3000, () => {
    console.log('Сервер запущен!')
})