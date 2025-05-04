<script setup>
const props = defineProps({
  url: String,
})
const formattedUrl = `https://${props.url}`
</script>

<template>
  <a :href="formattedUrl" class="rounded">
    <slot />
  </a>
</template>
