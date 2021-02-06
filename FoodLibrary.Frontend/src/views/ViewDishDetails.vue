<template>
  <b-container>
    <ViewDishDetails />
  </b-container>
</template>

<script lang="ts">
import Vue from 'vue';
import ViewDishDetails from '../components/ViewDishDetails.vue';

export default Vue.extend({
  components: {
    ViewDishDetails
  },
});
</script>