<script setup>
import Icon from '../atoms/Icon.vue'
import Pill from '../atoms/Pill.vue'

defineProps({
  startDate: String,
  endDate: String,
})
</script>

<template>
  <p class="py-2">
    <Icon icon="calendar" class="me-1" />
    {{ startDate }}
    -
    <span v-if="endDate != 'now'">{{ endDate }}</span>
    <Pill v-else text="now" />
  </p>
</template>
