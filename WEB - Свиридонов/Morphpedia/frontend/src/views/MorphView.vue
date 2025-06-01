<template>
  <router-link class="cancel" to="/">← Назад в каталог</router-link>

  <div class="morph-detail" v-if="morph">
    <img :src="getImageUrl(morph.imagePath)" alt="Фото морфы" class="morph-image" />
    <h1>{{ morph.title }}</h1>
    <p>{{ morph.description }}</p>
    <p class="date">Открыта: {{ morph.yearOpening }}</p>
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

    async fetchMorph() 
    {
      try 
      {
        const response = await fetch(`https://localhost:7049/api/morphs/${this.id}`);
        if (!response.ok) throw new Error('Не удалось получить данные');
        this.morph = await response.json();
      } 
      catch (err) 
      {
        console.error(err);
      }
    },

    getImageUrl(imagePath) 
    {
      return `https://localhost:7049/${imagePath}`;
    },
  },

  mounted() 
  {
    this.fetchMorph();
  }
};
</script>

<style scoped>
.morph-detail {
  max-width: 800px;
  margin: 2rem auto;
  padding: 2rem;
  text-align: center;
  border: 1px solid #ccc;
  border-radius: 1rem;
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
  display: inline-block;
  margin-top: 2rem;
  text-decoration: none;
  color: #42b983;
  font-weight: bold;
}

.date{
  color: black;
}
</style>
