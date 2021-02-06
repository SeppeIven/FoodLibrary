<template>
  <b-container>
    <b-row>
      <b-card
        overlay
        img-src="https://picsum.photos/900/250/?image=3"
        text-variant="white"
        v-bind:title="item.name"        
      >
      <b-card-text>
        Prepraration time: {{item.preparationTimeMinutes}} <br>
        Meat type: {{item.meat}} <br>
        Meal type: {{item.mealType}}
      </b-card-text>
      </b-card>
      
    </b-row>
    

  </b-container>
</template>

<script lang="ts">
import FoodLibraryDataService from "../services/FoodLibraryDataService";
import {Dish} from "../services/FoodLibraryDataService";
import axios from 'axios';
import { Vue, Component, Prop } from 'vue-property-decorator';

@Component
export default class ViewDishDetails extends Vue {

  public item: Dish = ({} as any) as Dish;

  public async created(){
    FoodLibraryDataService.get(this.$route.params.dishID)
      .then((response) => {
        this.item = response.data as Dish;
      })
      .catch((e) => {
        console.log(e);
      });
  }

}

</script>

<style scoped>
.submit-form {
  max-width: 300px;
  margin: auto;
}
</style>