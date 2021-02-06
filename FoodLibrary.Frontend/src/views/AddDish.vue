<template>
<div>
  <h1> Add dish </h1>
<AddDish />
</div>
</template>

<script lang="ts">
import Vue from 'vue';
import AddDish from '../components/AddDish.vue';

export default Vue.extend({
  components: {
    AddDish
  },
});
</script>