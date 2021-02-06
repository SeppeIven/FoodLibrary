<template>
  
<div class="home">
        <h1 align="center">Food Library</h1>
        <NineRandomDishes />
</div>  


</template>

<script lang="ts">
import { Component, Vue } from 'vue-property-decorator';
import VueResource from 'vue-resource';
import NineRandomDishes from '../components/NineRandomDishes.vue'

    export default Vue.extend({
    components: {
        NineRandomDishes
    },
    
    });




</script>