<template>
  <router-view/>

  <!-- ЛАБА 1
  <p>Добро пожаловать</p>

  <p>Ваш счет: {{ count }}</p>
  <button @click="clickCount">Нажми на меня</button>
  
  <h1>Книги Стивена</h1>
    
  <div v-if="loading" class="loading">Загрузка данных...</div>
  <div v-else>
    <div v-if="books.length > 0" class="book-list">
      <div v-for="book in books" :key="book.id" class="book-card">
        <h2>{{ book.Title }} ({{ book.Year }})</h2>
        <div class="book-meta">
          <p><strong>Издатель:</strong> {{ book.Publisher }}</p>
          <p><strong>Страниц:</strong> {{ book.Pages }}</p>
        </div>
      </div>
    </div>
    <div v-else class="no-books">Книги не найдены</div>
  </div>

  ЛАБА 2
  <div>
    <label for="textInput">Введите текст:</label>
    <input type="text" id="textInput" v-model="newTask.Title">

    <label class="datalabel" for="dateInput">Выберите дату:</label>
    <input type="date" id="dateInput" v-model="newTask.date"><br><br>

    <label for="prioritySelect">Выберите приоритет:</label>
    <select id="prioritySelect" v-model="newTask.priority">
      <option value="важно">Важно</option>
      <option value="очень важно">Очень важно</option>
      <option value="нормик">Нормик</option>
    </select><br><br>

    <button @click="clickAddTask">Добавить</button>

    <div v-for="task in tasks" :key="task.id">
      <h2>{{ task.Title }} ({{ task.date }}) ({{ task.priority }})</h2>
      <p><strong>Задача:</strong> {{ task.Title }}</p>
      <p><strong>Дата:</strong> {{ task.date }}</p>
      <p><strong>Важность:</strong> {{ task.priority }}</p>
    </div>
  </div> -->
</template>

<script>
import axios from 'axios';

export default {
  data() {
    return {
      abc: "Привет",
      books: [],
      count: 0,
      isNatural: true,
      loading: false,
      newTask: {
        Title: '',
        date: '',
        priority: 'важно', // по умолчанию
      },
      tasks: [],
      nextId: 1,
    };
  },

  async created() {
    await this.loadBooks();
  },

  methods: {
    async loadBooks() {
      this.loading = true;
      try {
        let response = await axios.get('https://stephen-king-api.onrender.com/api/books');
        this.books = response.data.data;
      } catch (error) {
        console.error("Ошибка при загрузке книг:", error);
      } finally {
        this.loading = false;
      }
    },

    clickAddTask()
    {
      let task =
      {
        id: this.nextId++,
        Title: this.newTask.Title,
        date: this.newTask.date,
        priority: this.newTask.priority,
      };
      this.tasks.push(task);

      this.newTask.Title = '';
      this.newTask.date = '';
    },

    clickCount() {
      console.log("Меня зажали");
      this.count++;
    }
  }
};
</script>

<style scoped> /*scoped все стили будут применимы только для этого файла*/
.app {
  max-width: 1000px;
  margin: 0 auto;
  padding: 20px;
}

.datalabel{
  margin-left: 2rem;
}

.loading, .no-books {
  text-align: center;
  padding: 20px;
  font-size: 1.2em;
  color: #666;
}

.book-list {
  display: grid;
  grid-template-columns: repeat(auto-fill, minmax(300px, 1fr));
  gap: 25px;
  margin-top: 30px;
}

.book-card {
  background: white;
  border-radius: 8px;
  box-shadow: 0 2px 8px rgba(0, 0, 0, 0.1);
  padding: 20px;
  transition: transform 0.3s ease, box-shadow 0.3s ease;
}

.book-card h2 {
  color: #2c3e50;
  margin-top: 0;
  border-bottom: 1px solid #eee;
  padding-bottom: 10px;
}

.book-meta {
  margin: 15px 0;
}

.book-meta p {
  margin: 5px 0;
  color: #555;
}

.villains {
  margin-top: 15px;
  padding-top: 15px;
  border-top: 1px dashed #ddd;
}

.villains h3 {
  margin-bottom: 10px;
  font-size: 1.1em;
  color: #c0392b;
}

.villains ul {
  list-style-type: none;
  padding-left: 0;
  margin: 0;
}

.villains li {
  padding: 5px 0;
  border-bottom: 1px solid #f5f5f5;
}

.villains li:last-child {
  border-bottom: none;
}
</style>
