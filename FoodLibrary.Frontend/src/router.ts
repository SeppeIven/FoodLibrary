import Vue from 'vue';
import Router from 'vue-router';

import AddDish from './views/AddDish.vue';
import FoodLibraryHome from './views/FoodLibraryHome.vue';
import ViewDishDetails from './views/ViewDishDetails.vue';

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
      component: FoodLibraryHome,
      meta: {
        requiresAuth: true
      },
    },
    {
      path:'/add-dish',
      name:'AddDish',
      component: AddDish
    },  
    {
      path:'/view-dish-details/:dishID',
      name:'ViewDishDetails',
      component: ViewDishDetails
    },  
  ],
});

export default router;

