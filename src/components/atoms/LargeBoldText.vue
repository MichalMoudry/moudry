<script setup>
const props = defineProps({
  text: String
})
</script>

<template>
  <span class="font-bold text-xl">{{ text }}</span>
</template>
