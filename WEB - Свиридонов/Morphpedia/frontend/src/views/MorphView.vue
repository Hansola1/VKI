<template>
  <div class="header-container">
    <router-link class="cancel" to="/">←</router-link>
    <button class="delete-btn" @click="deleteMorph">
      <img src="./src/assets/images/basket.png" alt="Удалить" />
    </button>

    <button class="edit-btn" @click="editMorph">
      <img src=".src/assets/images/editPen.png" alt="Редактировать" />
    </button>
  </div>

  <div class="morph-detail" v-if="morph">
    <img :src="getImageUrl(morph.imagePath)" alt="Фото морфы" class="morph-image" />
    <h1>{{ morph.title }}</h1>
    <p>{{ morph.description }}</p>
    <p class="date">Открыта: {{ morph.yearOpening }}</p>
    <p class="type">Тип: {{ morph.type }}</p>
  </div>
</template>

<script>
export default {
  name: 'MorphView',
  props: {
    id: {
      type: String,
      required: true
    }
  },

  data() {
    return {
      morph: null
    };
  },

  methods: {
    async fetchMorph() {
      try {
        const response = await fetch(`https://localhost:7049/api/morphs/${this.id}`);
        if (!response.ok) throw new Error('Не удалось получить данные');
        this.morph = await response.json();
      } 
      catch (err) {
        console.error(err);
      }
    },

    async deleteMorph() 
    {
      try 
      {
        const response = await fetch(`https://localhost:7049/api/morphs/${this.id}`, {
          method: 'DELETE' //тип HTTP-запроса.
        });
        
        if (!response.ok) throw new Error('Не удалось удалить морфу');
        this.$router.push('/');
      }
      catch (err) 
      {
        console.error(err);
        alert('Ошибка при удалении морфы');
      }
    },

    async editMorph() {
       //this.$router.push(`/edit-morph/${this.id}`);
    },

    getImageUrl(imagePath) {
      return `https://localhost:7049/${imagePath}`;
    },
  },

  mounted() {
    this.fetchMorph();
  }
};
</script>

<style scoped>
@font-face {
  font-family: 'Codenext';
  src: url('./assets/fonts/CodeNext-Trial-ExtraBold.ttf') format('truetype');
  font-weight: 800;
  font-style: normal;
}

.header-container {
  display: flex;
  justify-content: space-between;
  align-items: center;
  padding: 0 2rem;
  margin-top: 4rem;
}

.morph-detail {
  max-width: 800px;
  margin: 2rem auto;
  padding: 2rem;
  text-align: center;
  border: 1px solid #ccc;
  border-radius: 1rem;
  margin-bottom: 300px;
}

.morph-image {
  max-width: 100%;
  height: auto;
  border-radius: 8px;
  margin-bottom: 1rem;
}

h1 {
  font-size: 2.2rem;
  margin-bottom: 1rem;
}

p {
  font-size: 1.2rem;
  margin-bottom: 1rem;
}

a.cancel {
  text-decoration: none;
  font-family: 'Codenext', sans-serif; 
  letter-spacing: 2px;
  font-weight: bold;
  font-size: 2.5rem;
  color: #4C4C4C;
}

.date {
  color: black;
}

.delete-btn {
  background: none;
  border: none;
  cursor: pointer;
  padding: 0;
  width: 40px;
  height: 40px;
}

.delete-btn img {
  width: 100%;
  height: 100%;
  object-fit: contain;
}
</style>