<script setup>
import Icon from '../atoms/Icon.vue'
const props = defineProps({
  icon: String,
  text: String,
})
</script>

<template>
  <p>
    <Icon :icon="icon" class="me-2 text-xl" />
    {{ text }}
  </p>
</template>
