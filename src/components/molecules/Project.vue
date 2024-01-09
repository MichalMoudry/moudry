<script setup>
const props = defineProps({
  header: String,
  isFirst: {
    type: Boolean,
    default: false
  }
})
</script>

<template>
  <div :class="{ 'mt-2': isFirst, 'mt-5': !isFirst }" class="project">
    <div class="bg-primary-300 rounded py-2 px-3">
      <span class="font-bold">{{ header }}</span>
    </div>

    <div class="px-4 py-1 text-justify">
      <slot />
    </div>
  </div>
</template>
