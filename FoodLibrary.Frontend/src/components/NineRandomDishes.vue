<template>
  <div>
    <b-row v-for="i in Math.ceil(nineRandomDishes.length / 3)" :key="i">
      <b-col></b-col>
      <b-col cols="8">
          <b-card-group deck>
            <b-card
              v-for="item in nineRandomDishes.slice((i-1)*3,i*3)" 
              v-bind:key="item.id"
              v-bind:title="item.name"
              img-src="https://picsum.photos/600/300/?image=25"
              img-alt="Image"
              img-top
              tag="article"
              style="max-width: 20rem;"
              class="mb-2"
            >
              <b-card-text>
                Preparation time (minutes): {{item.preparationTimeMinutes}} <br>
                {{item.meat}} <br>
                {{item.mealType}}
              </b-card-text>
              <b-button href="#" class="btn btn-success">Details</b-button>
            </b-card>
          </b-card-group>
      </b-col>
      <b-col></b-col>  
    </b-row>
  </div>
</template>

<script lang="ts">
import FoodLibraryDataService from "../services/FoodLibraryDataService";
import {Dish} from "../services/FoodLibraryDataService"
import axios from 'axios';
import { Vue, Component, Prop } from 'vue-property-decorator';

@Component
export default class NineRandomDishes extends Vue {

  public nineRandomDishes: Dish[] = [];

  public async created(){
    this.nineRandomDishes = await FoodLibraryDataService.getNineRandomDishes();
  }
}

</script>

<style scoped>
.v-application a {
    color: white;
}
</style>