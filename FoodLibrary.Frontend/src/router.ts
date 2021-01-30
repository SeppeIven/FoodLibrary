import Vue from 'vue';
import Router from 'vue-router';

import Home from './views/Home.vue';
import AddStockPurchase from './views/AddStockPurchase.vue';
import FoodLibraryHome from './views/FoodLibraryHome.vue';

Vue.use(Router);

let router = new Router({
  routes: [
    { 
      path: '/',
      redirect: '/home'
    },
    {
      path: '/home',
      name: 'home',
      component: Home,
      meta: {
        requiresAuth: true
      },
    },
    {
      path:'/add-stock-purchase',
      name:'AddStockPurchase',
      component: AddStockPurchase
    },  
    {
      path:'/food-library-home',
      name:'FoodLibraryHome',
      component: FoodLibraryHome
    },  
  ],
});

export default router;

