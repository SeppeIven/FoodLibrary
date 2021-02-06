<template>
  <div>
    <b-row v-for="i in Math.ceil(items.length / 3)" :key="i">
      <b-col></b-col>
      <b-col cols="8">
          <b-card-group deck>
            <b-card
              v-for="item in items.slice((i-1)*3,i*3)" 
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
                Some quick example text to build on the card title and make up the bulk of the card's content.
              </b-card-text>

              <b-button href="#" variant="primary">Go somewhere</b-button>
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

  public items: Dish[] = [];

  private submitted: boolean = false;

  public async created(){
    FoodLibraryDataService.getNineRandomDishes()
      .then((response) => {
        this.items = response.data as Dish[];
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