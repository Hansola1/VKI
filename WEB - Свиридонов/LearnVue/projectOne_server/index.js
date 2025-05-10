const express = require('express');
const cors = require('cors');
const bodyParser = require('body-parser');

const sqlite = require('sqlite3').verbose();
const db = new sqlite.Database('DB/base.db', (err) => {
    if (err)
    {
        return console.log(err);
    }
    console.log('Все норм =)')
});

const app = express();
app.use(cors());
app.use(bodyParser.json());

app.post('/login', (request, response) => {
    console.log(request.body) //хотим смотреть тело запроса

    let login = request.body.login;
    let password = request.body.password;
    db.get(`SELECT * FROM Users WHERE login="${login}" AND password="${password}"`, (error, row) => {
        if(error)
        {
            console.log(error);
        }
        else
        {
            console.log(row);
            if(row == undefined)
            {
                response.status(400).send({
                    success: false,
                    message: 'Пользователь не найден'
                })
            }
            else
            {
                response.send({
                    success: true,
                    info: row + 'Пользователь найден'
                })
            }
        }
    }) //db.all искать по всем, брать все.
})

app.listen(3000, () => {
    console.log('Сервер запущен!')
})