<template>
  <div class="card" @click="$emit('click')">
    <img :src="getImageUrl(morph.imagePath)" alt="Фото морфы" class="morph-image" />
    <h3>{{ morph.title }}</h3>
  </div>
</template>

<script>
export default {
  name: 'MorphCard',
  props: ['morph'],

    methods: {
    getImageUrl(imagePath) 
    {
      return `https://localhost:7049/${imagePath}`;
    },
  }
}
</script>

<style scoped>
.card {
  background: #f0f0f0;
  border-radius: 12px;
  padding: 1rem;
  width: 200px;
  cursor: pointer;
  transition: transform 0.2s, background-color 0.2s;
}
.morph-image {
  width: 150px;
  height: auto;
  border-radius: 8px;
  object-fit: cover;
  margin-bottom: 10px;
}

.card:hover {
  transform: scale(1.03);
  background-color: #e0e0e0;
}

.card h3 {
  margin: 0 0 0.5rem;
}

.card p {
  font-size: 0.9rem;
  color: #555;
}
</style>