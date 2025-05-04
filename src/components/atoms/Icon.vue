<script setup>
const props = defineProps({
  icon: String
})
let iconClass = `bi bi-${props.icon}`;
</script>

<template>
  <i :class="iconClass"></i>
</template>