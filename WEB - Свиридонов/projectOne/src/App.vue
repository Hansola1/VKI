<!-- <script setup>
import HelloWorld from './components/HelloWorld.vue'
</script> -->

<template>
<!--<div>
    <a href="https://vite.dev" target="_blank">
      <img src="/vite.svg" class="logo" alt="Vite logo" />
    </a>
    <a href="https://vuejs.org/" target="_blank">
      <img src="./assets/vue.svg" class="logo vue" alt="Vue logo" />
    </a>
  </div>
  <HelloWorld msg="Vite + Vue" /> -->

  <p>Добро пожаловать</p>
  <p>Ваш счет: {{ count }}</p>
  <button @click="clickCount">Нажми на меня</button> <!--присваем фунцию-->
  

</template>

<script>
export default {
  data()
  {
    return {
      abc: "Привет",
      count: 0,
      isNatural: true
    }  
  },

  methods: {
    clickCount(){
      console.log("Меня зажали");
      this.count++;
    }
  }
}
</script>

<style scoped> /*scoped все стили будут применимы только для этого файла*/

</style>
