<template>
  <div class="catalog">
    <h1>Каталог рептилий</h1>

    <div class="morph-list">
      <MorphCard
        v-for="morph in morphs"
        :key="morph.id"
        :morph="morph"
        @click="goToMorph(morph.id)"/>
    </div>

  </div>
</template>

<script>
import MorphCard from '../components/MorphCard.vue'

export default {
  name: 'CatalogView',
  components: { MorphCard },

  data() {
    return {
        morphs: []
        // morphs: [
        // { id: 1, name: 'Геккон', description: 'Маленькая ящерица с липкими лапками.' },
        // { id: 2, name: 'Игуана', description: 'Зелёная травоядная рептилия.' },
        // { id: 3, name: 'Хамелеон', description: 'Мастер маскировки с высовывающимся языком.' }]
    }
  },

  methods: {
    async loadMorphs() 
    {
      try 
      {
        const response = await fetch('https://localhost:7049/api/morphs'); 
        const data = await response.json();
        this.morphs = data;
      } 
      catch (error) 
      {
        console.error('Ошибка загрузки:', error);
      }
    },

    goToMorph(id) 
    {
      this.$router.push({ name: 'Morph', params: { id } })
    }
  },

  mounted() 
  {
    this.loadMorphs();
    // this.morphs = [
    //   { id: 1, name: 'Геккон', description: 'Маленькая ящерица...' },
    //   { id: 2, name: 'Игуана', description: 'Крупная травоядная рептилия...' }
    // ]
  }
}
</script>

<style scoped>
.catalog {
  padding: 2rem;
  max-width: 900px;
  margin: 0 auto;
  text-align: center;
}

.catalog h1 {
  font-size: 2.5rem;
  margin-bottom: 2rem;
}

.morph-list {
  display: flex;
  flex-wrap: wrap;
  justify-content: center;
  gap: 1.5rem;
}
</style>
