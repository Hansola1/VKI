<template>
    <p>ГЛАВНАЯ СТРАНИЦА</p>
    <button @click="goBack">Назад</button>
    <input type="text" v-model="login"/>
    <input type="password"  v-model="password"/>
    <button @click="test">Нажми для ответа бека</button>
</template>

<script>
import axios from 'axios';

export default
{
    data()
    {
        return {
        }
    },
    methods:{
        goBack()
        {
             //window.history.back(); --- Переход назад, 1 способ
             this.$router.back(); // --- Переход назад, 2 способ на Vue
        },

        test(){
            axios.post('http://localhost:3000/login', {
                login: this.login,
                password: this.password
            })
            .catch(err => {
                console.log(err)
            })
        }
    }
};

</script>

<style scoped>
</style>
