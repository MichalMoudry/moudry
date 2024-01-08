<script setup>
import LargeBoldText from '../atoms/LargeBoldText.vue'
import Link from '../atoms/Link.vue'

const props = defineProps({
  name: String,
  description: String,
  url: String
})
</script>

<template>
  <LargeBoldText :text="name" />
  <p class="py-2">
    {{ description }}
  </p>
  <p>Link: <Link :url="url" title="Link to the project site" content="Link" /></p>
</template>
