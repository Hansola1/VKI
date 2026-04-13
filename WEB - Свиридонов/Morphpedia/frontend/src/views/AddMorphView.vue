<template>
  <div class="edit-container">
    <h1>Добавление новой морфы</h1>
    <form @submit.prevent="saveMorph" class="edit-form">
      <div class="form-group">
        <label>Название:</label>
        <input v-model="formData.title" type="text" required>
      </div>
      
      <div class="form-group">
        <label>Описание:</label>
        <textarea v-model="formData.description" rows="4" required></textarea>
      </div>
      
      <div class="form-group">
        <label>Год открытия:</label>
        <input v-model="formData.yearOpening" type="text" required>
      </div>
      
      <div class="form-group">
        <label>Тип:</label>
        <input v-model="formData.type" type="text" required>
      </div>
      
      <div class="form-group">
        <label>Изображение (путь):</label>
        <input v-model="formData.imagePath" type="text" required>
      </div>

      <div class="btn-edit">
        <router-link class="cancel-btn" to="/">Назад</router-link>
        <button type="submit" class="save-btn" :disabled="isSaving">
          {{ isSaving ? 'Сохранение...' : 'Добавить морфу' }}
        </button>
      </div>
    </form>
  </div>
</template>

<script>
export default {
  name: 'AddMorph',
  data() {
    return {
      formData: {
        title: '',
        description: '',
        yearOpening: '',
        type: '',
        imagePath: ''
      },
      isSaving: false
    }
  },
  methods: {
    async saveMorph() {
      if (this.isSaving) return;
      
      this.isSaving = true;
      
      try {
        const response = await fetch('https://localhost:7049/api/morphs', {
          method: 'POST',  // Используем POST для создания
          headers: {
            'Content-Type': 'application/json',
          },
          body: JSON.stringify(this.formData)
        });
        
        if (!response.ok) {
          const errorData = await response.json();
          throw new Error(errorData.title || 'Не удалось добавить морфу');
        }
        
        const createdMorph = await response.json();
        this.$router.push({ name: 'Morph', params: { id: createdMorph.id } });
        
      } catch (err) {
        console.error('Ошибка сохранения:', err);
        alert(`Ошибка при добавлении: ${err.message}`);
      } finally {
        this.isSaving = false;
      }
    }
  }
}
</script>

<style scoped>
.edit-container {
  max-width: 800px;
  margin: 0 auto;
  padding: 20px;
  margin-bottom: 8rem;
  padding-top: 2rem;
}

h1 {
  text-align: center;
  margin-bottom: 30px;
  font-family: 'Codenext', sans-serif;
  font-size: 1.9rem;
  letter-spacing: 1px;
  margin-top: 2rem;
  margin-bottom: 2rem;
}

label{
  font-family: 'Codenext', sans-serif;
  font-size: 1rem;
  margin-top: 1rem;
  margin-bottom: 1rem;
  letter-spacing: 1px;
}

.edit-form {
  background: #f9f9f9;
  padding-right: 2rem;
  padding-left: 1rem;
  padding-bottom: 1rem;
  padding-top: 0.5rem;
  border-radius: 12px;
  box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);
}

.form-group {
  margin-bottom: 20px;
}

.form-group label {
  display: block;
  margin-bottom: 8px;
  font-weight: 600;
}

.form-group input[type="text"],
.form-group textarea {
  width: 100%;
  padding: 10px;
  border: 1px solid #ddd;
  border-radius: 6px;
  font-size: 1rem;
}

.form-group textarea {
  resize: vertical;
  min-height: 100px;
}

.save-btn {
  margin-top: 0.6rem;
  margin-bottom: 1rem;
  background-color: #000000;
  color: white;
  border: none;
  padding: 12px 20px;
  border-radius: 15px; 
  cursor: pointer;
  font-size: 1rem;
  transition: background-color 0.3s;
  font-family: 'Codenext', sans-serif;
  font-size: 1rem;
  letter-spacing: 1px;
}

.save-btn:hover, .cancel-btn:hover {
  border-radius: 10px; 
}

.save-btn:disabled {
  background-color: #666;
  cursor: not-allowed;
}

.cancel-btn{
  margin-top: 0.6rem;
  margin-bottom: 1rem;
  background-color: #000000;
  color: white;
  border: none;
  padding: 12px 20px;
  border-radius: 15px; 
  cursor: pointer;
  font-size: 1rem;
  transition: background-color 0.3s;
  font-family: 'Codenext', sans-serif;
  font-size: 1rem;
  letter-spacing: 1px;
  text-decoration: none;
}

.btn-edit{
    display: flex;
    gap: 1rem;
}
</style>