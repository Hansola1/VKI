import { createRouter, createWebHistory } from 'vue-router';
import CatalogView from '../views/CatalogView.vue';
import MorphView from '../views/MorphView.vue';
import EditMorph from '../views/EditMorphView.vue'; 
import AddMorph from '../views/AddMorphView.vue'; 

const routes = [
  { path: '/', name: 'Catalog', component: CatalogView },
  { path: '/morph/:id', name: 'Morph', component: MorphView, props: true },
  { path: '/edit-morph/:id', name: 'EditMorph', component: EditMorph, props: true },
  { path: '/add-morph', name: 'AddMorph', component: AddMorph} // какие здесь props!?!?! не видишь айди создаем!?!?
]

const router = createRouter({
  history: createWebHistory(),
  routes
})

export default router;