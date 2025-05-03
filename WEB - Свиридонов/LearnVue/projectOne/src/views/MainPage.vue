<template>
    <p>ГЛАВНАЯ СТРАНИЦА</p>
    <button @click="goLogin">Авторизация</button>
</template>

<script>
export default
{
    data()
    {
        return {
        }
    },
    methods:{
        goLogin()
        {
            //window.location.href = '/login'; - 1 способ перехода между страницами
            this.$router.push('/login'); //Singl page application SPA. Моментальный переход
        }
    }
};

</script>

<style scoped>
</style>
