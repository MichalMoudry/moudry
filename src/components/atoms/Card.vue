<script setup>
const props = defineProps({
  hasPadding: {
    type: Boolean,
    default: true
  }
})
</script>

<template>
    <div class="bg-white rounded-md shadow flex flex-col" :class="{ 'p-6': props.hasPadding }">
        <slot />
    </div>
</template>