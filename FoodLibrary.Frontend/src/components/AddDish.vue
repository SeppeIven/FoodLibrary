<template>
  <div>
    <b-container>
      <b-form v-if="showAddDishForm">
        <b-form-group
          id="input-group-1"
          label="Dish name:"
          label-for="input-1"
        >
          <b-form-input
            id="input-1"
            v-model="DishToBeAdded.Name"
            type="text"
            placeholder="Dish name"
            required
          ></b-form-input>
        </b-form-group>

        <b-form-group id="input-group-2" label="Preparation time in minutes:" label-for="input-2">
          <b-form-input
            id="input-2"
            v-model="DishToBeAdded.PreparationTimeMinutes"
            type="number"
            placeholder="Preparation time (minutes)"
            required
          ></b-form-input>
        </b-form-group>

        <b-form-group id="input-group-3" label="Meat type:" label-for="input-3">
          <b-form-select
            id="input-3"
            v-model="DishToBeAdded.meatTypes"
            :options="meatTypes"
            required
          ></b-form-select>
        </b-form-group>

        <b-form-group id="input-group-4" label="Meal type:" label-for="input-4">
          <b-form-select
            id="input-4"
            v-model="DishToBeAdded.mealTypes"
            :options="mealTypes"
            required
          ></b-form-select>
        </b-form-group>


        <button @click="submitDish" class="btn btn-success">Submit</button>

        <!-- <b-button type="submit" variant="primary">Submit</b-button>
        <b-button type="reset" variant="danger">Reset</b-button> -->
      </b-form>
    </b-container>
  </div>
</template>

<script lang="ts">
import FoodLibraryDataService from "../services/FoodLibraryDataService";
import axios from 'axios';
import { Vue, Component, Prop } from 'vue-property-decorator';

@Component
export default class AddDish extends Vue {

public showAddDishForm: boolean = true;
public meatTypes: String[] = ["Normal", "Veggie", "Vegan"];
public mealTypes: String[] = ["Lunch", "Dinner", "Snack"];

public dishName: string = "";

public DishToBeAdded: Dish = {ID:1,Name:"",PreparationTimeMinutes:10,Meat:"",MealType:""};

public submitDish():void{

}

/*   public submitNewStockPurchase():void{
    this.newStockPurchase.Tracker = this.trackerForStockPurchase;
    this.newStockPurchase.PricePerShare = this.pricepershareForStockPurchase;
    this.newStockPurchase.Amount = this.amountForStockPurchase;
    this.newStockPurchase.LongOrShort = this.longorshortForStockPurchase;
    this.newStockPurchase.BuyOrSell = this.buyorsellForStockPurchase;
    this.newStockPurchase.PurchaseDate = this.purchasedateForStockPurchase;
    console.log(this.newStockPurchase);
    StockPurchasesDataService.create(this.newStockPurchase);
  } */




}

export interface Dish {
  ID: number;
  Name: string;
  PreparationTimeMinutes: number;
  Meat: string;
  MealType: string;
}

</script>