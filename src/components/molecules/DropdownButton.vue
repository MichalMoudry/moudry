<script setup>
import { ref } from 'vue'
import Icon from '../atoms/Icon.vue'

const displayClass = ref('hidden')

/**
 * Function for toggling display property of the dropdown.
 */
function toggleDropdown() {
  if (displayClass.value == 'hidden') {
    displayClass.value = 'block'
  } else {
    displayClass.value = 'hidden'
  }
}
</script>

<template>
  <div class="relative inline-block text-left rounded hover:bg-primary-300">
    <button class="rounded py-1 px-2" @click="toggleDropdown">
      <Icon icon="ellipses" :is-primary="false" />
    </button>

    <div
      class="absolute bg-white right-0 z-10 origin-top-right rounded shadow w-56 ring-1 ring-black ring-opacity-5"
      :class="displayClass"
    >
      <div class="py-1" role="none">
        <slot />
      </div>
    </div>
  </div>
</template>
