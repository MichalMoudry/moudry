<script setup>
import Icon from '../atoms/Icon.vue'
const props = defineProps({
  icon: String,
  text: String
})
</script>

<template>
  <h2 class="flex items-center mb-4">
    <Icon :icon="icon" class="me-4 text-3xl" />
    <span class="text-2xl">{{ text }}</span>
  </h2>
</template>