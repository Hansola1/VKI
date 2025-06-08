<template>
  <div class="edit-container">
    <!-- БЕК ОЖИДАЕТ [FromBody] -->

    <router-link class="cancel" to="/">← Назад</router-link>
    <h1>Редактирование морфы</h1>
    <form @submit.prevent="saveChanges" class="edit-form">
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
        <label>Изображение(путь):</label>
        <input v-model="formData.imagePath" type="text" required>

        <!-- <input type="file" @change="handleImageUpload" accept="image/*">
        <img v-if="previewImage" :src="previewImage" class="image-preview">
        <img v-else :src="getImageUrl(formData.imagePath)" class="image-preview">  -->
    </div>

    <div class="btn-edit">
        <router-link class="cancel-btn" to="/">Назад</router-link>
        <button type="submit" class="save-btn">Сохранить изменения</button>
    </div>
    </form>
    </div>
</template>

<script>
export default {
  name: 'EditMorph',
  props: {
    id: {
      type: String,
      required: true
    }
  },
  data() {
    return {
      formData: {
        title: '',
        description: '',
        yearOpening: '',
        type: '',
        imagePath: ''
      },
      previewImage: null,
      selectedFile: null
    }
  },
  async created() {
    await this.fetchMorph();
  },
  methods: {
    async fetchMorph() 
    {
      try 
      {
        const response = await fetch(`https://localhost:7049/api/morphs/${this.id}`);
        if (!response.ok) throw new Error('Не удалось получить данные');
        const data = await response.json();
        this.formData = { ...data };

      } 
      catch (err) 
      {
        console.error(err);
        alert('Ошибка при загрузке данных морфы');
      }
    },
    
    getImageUrl(imagePath) {
      return `https://localhost:7049/${imagePath}`;
    },
    
    handleImageUpload(event) 
    {
    //   const file = event.target.files[0];
    //   if (file) {
    //     this.selectedFile = file;
    //     this.previewImage = URL.createObjectURL(file);
    //   }

    },
    
    async saveChanges() 
    {
        try 
        {
            const response = await fetch(`https://localhost:7049/api/morphs/${this.id}`, {
            method: 'PUT',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify({ 
                id: parseInt(this.id), 
                title: this.formData.title,
                description: this.formData.description,
                yearOpening: this.formData.yearOpening,
                type: this.formData.type,
                imagePath: this.formData.imagePath
            })
            });
            
            if (!response.ok) {
            const errorData = await response.json();
            throw new Error(errorData.message || 'Не удалось сохранить изменения');
            }
            
            this.$router.push({ name: 'Morph', params: { id: this.id } });
        } 
        catch (err) 
        {
            console.error('Ошибка сохранения:', err);
            alert(`Ошибка при сохранении: ${err.message}`);
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
}

.cancel {
  display: inline-block;
  margin-bottom: 20px;
  font-size: 1.2rem;
  color: #333;
  text-decoration: none;
}

.cancel:hover {
  color: #555;
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

.image-preview {
  display: block;
  max-width: 200px;
  max-height: 200px;
  margin-top: 10px;
  border-radius: 8px;
  object-fit: cover;
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