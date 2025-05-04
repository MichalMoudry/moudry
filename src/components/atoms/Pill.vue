<script setup>
defineProps({
  text: String,
})
</script>

<template>
  <span class="bg-primary-300 text-black rounded px-2 py-1">{{ text }}</span>
</template>
