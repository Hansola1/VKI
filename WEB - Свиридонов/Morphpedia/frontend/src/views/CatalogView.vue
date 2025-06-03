<template>
  <div class="catalog">
    <h1>Список морф африканского геккона:</h1>
    
    <template v-if="morphs.length > 0">
      <h2>* Доминантные и неполнодоминантные гены:</h2>
      <div class="morph-list">
        <MorphCard
          v-for="morph in dominantMorphs"
          :key="morph.id"
          :morph="morph"
          @click="goToMorph(morph.id)"/>
      </div>

      <h3>* Рецессивные гены:</h3>
      <div class="morph-list">
        <MorphCard
          v-for="morph in recessiveMorphs"
          :key="morph.id"
          :morph="morph"
          @click="goToMorph(morph.id)"/>
      </div>
    </template>
    <div v-else class="loading">
      Загрузка данных...
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
      morphs: [],
      isLoading: false,
      error: null
    }
  },

  computed: {
    dominantMorphs() {
      return this.morphs.filter(morph => morph.type === 'доминантный');
    },
    recessiveMorphs() {
      return this.morphs.filter(morph => morph.type === 'рецессивный');
    }
  },

  methods: {
    async loadMorphs() {
      this.isLoading = true;
      this.error = null;
      try {
        const response = await fetch('https://localhost:7049/api/morphs');
        if (!response.ok) {
          throw new Error('Ошибка загрузки данных');
        }
        const data = await response.json();
        this.morphs = data;
      } catch (error) {
        console.error('Ошибка загрузки:', error);
        this.error = error.message;
      } finally {
        this.isLoading = false;
      }
    },

    goToMorph(id) {
      this.$router.push({ name: 'Morph', params: { id } })
    }
  },

  mounted() {
    this.loadMorphs();
  }
}
</script>

<style scoped>
@font-face {
  font-family: 'TovariSans';
  src: url('./assets/fonts/tovari-sans.woff2') format('woff2'),
      url('./assets/fonts/tovari-sans.woff') format('woff'),
      url('./assets/fonts/tovari-sans.otf') format('opentype');
  font-weight: bold;
}

.catalog {
  padding: 2rem;
  max-width: 900px;
  margin: 0 auto;
  text-align: center;
}

.catalog h1 {
  font-size: 1.5rem;
  margin-bottom: 1rem;
  font-family: 'TovariSans', sans-serif; 
  letter-spacing: 2px;
  margin-top: 70px;
  color: #4C4C4C;
  text-align: left;
}

.catalog h2 {
  margin-bottom: 1rem;
  font-family: 'TovariSans', sans-serif; 
  letter-spacing: 2px;
  font-size: 1rem;
  margin-top: 2rem;
  color: #919191;
  text-align: left;
}

.catalog h3 {
  margin-bottom: 1rem;
  font-family: 'TovariSans', sans-serif; 
  letter-spacing: 2px;
  font-size: 1rem;
  margin-top: -6rem;
  color: #919191;
  text-align: left;
}

.morph-list {
  display: flex;
  flex-wrap: wrap;
  justify-content: center;
  gap: 1.5rem;
  margin-bottom: 8rem;
}
</style>
