<script setup>
const props = defineProps({
  icon: String
})
</script>

<template>
  <span class="oi" :data-glyph="props.icon" />
</template>