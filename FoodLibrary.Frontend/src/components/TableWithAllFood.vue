<template>
  <div>
    <b-row>
      <b-col></b-col>
      <b-col>          
        <b-pagination
          v-model="currentPage"
          :total-rows="rows"
          :per-page="perPage"
          aria-controls="my-table"
        ></b-pagination>
      </b-col>
      <b-col></b-col>
    </b-row>
    <b-row>
      <b-col></b-col>
      <b-col cols="8"><b-table striped hover :items="items" :per-page="perPage" :current-page="currentPage"></b-table></b-col>
      <b-col></b-col>
    </b-row>
    

  </div>
</template>

<script lang="ts">
import FoodLibraryDataService from "../services/FoodLibraryDataService";
import {Dish} from "../services/FoodLibraryDataService";
import axios from 'axios';
import { Vue, Component, Prop } from 'vue-property-decorator';

@Component
export default class TableWithAllFood extends Vue {

  public perPage: number = 3;
  public currentPage: number = 1;
  public items: Dish[] = [];

  public trackerForStockPurchase="VUSA";
  public pricepershareForStockPurchase=20;
  public amountForStockPurchase=30;
  public longorshortForStockPurchase="Long";
  public buyorsellForStockPurchase="Buy";
  public purchasedateForStockPurchase = new Date;

  //private newStockPurchase: StockPurchaseWithoutID = {Tracker:"",PricePerShare:0,Amount:0,LongOrShort:"",BuyOrSell:"",PurchaseDate:new Date()};

  private submitted: boolean = false;

  private get rows(): number {
    return this.items.length;
  }

  public async created(){
    FoodLibraryDataService.getAll()
      .then((response) => {
        this.items = response.data as Dish[];
          for(let entry of response.data)
            console.log(entry.name)
        console.log(response.data);
        console.log(this.items)
      })
      .catch((e) => {
        console.log(e);
      });
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

</script>

<style scoped>
.submit-form {
  max-width: 300px;
  margin: auto;
}
</style>