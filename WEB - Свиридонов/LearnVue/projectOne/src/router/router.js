import MainPage from '../views/MainPage.vue'
import LoginPage from '../views/LoginPage.vue'
import { createRouter, createWebHistory } from 'vue-router'

const routes = [
    {
        path: '/',
        name: 'MainPage',
        component: MainPage,
    },
    {
        path: '/login',
        name: 'LoginPage',
        component: LoginPage,
    }
]
const router = createRouter({
    routes,
    history: createWebHistory()
})

export default router