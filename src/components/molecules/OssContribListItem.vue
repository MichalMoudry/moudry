<script setup>
import LargeBoldText from '../atoms/LargeBoldText.vue'
import Link from '../atoms/Link.vue'

const props = defineProps({
  name: String,
  url: String,
})
</script>

<template>
  <LargeBoldText :text="name" />
  <div class="py-2">
    <slot />
  </div>
  <p>
    <Link :url="url" title="Link to the project"> Go to project page </Link>
  </p>
</template>
