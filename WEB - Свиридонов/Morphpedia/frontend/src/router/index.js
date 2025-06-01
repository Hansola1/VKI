import { createRouter, createWebHistory } from 'vue-router';
import CatalogView from '../views/CatalogView.vue';
import MorphView from '../views/MorphView.vue';

const routes = [
  { path: '/', name: 'Catalog', component: CatalogView },
  { path: '/morph/:id', name: 'Morph', component: MorphView, props: true }
]

const router = createRouter({
  history: createWebHistory(),
  routes
})

export default router;