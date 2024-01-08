<script setup>
const props = defineProps({
  content: String,
  icon: String
})
</script>

<template>
  <button class="border-primary-300 border rounded py-1 px-2 hover:bg-primary-300">
    <!--<Icon :icon="icon" is-primary="false" />-->
    {{ content }}
  </button>
</template>
