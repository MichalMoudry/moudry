<script setup>
const props = defineProps({
  icon: String,
  isPrimary: {
    type: Boolean,
    default: true
  }
})
</script>

<template>
  <span class="oi" :class="{ 'text-primary-300': isPrimary }" :data-glyph="props.icon" />
</template>