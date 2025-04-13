import { createApp } from 'vue';
import './style.css';
import App from './App.vue';

const app = createApp(App);

import axios from 'axios';
app.config.globalProperties.$axios = axios;

app.mount('#app');