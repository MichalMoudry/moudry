<script setup>
import LargeBoldText from '../atoms/LargeBoldText.vue'
import DateRange from '../molecules/DateRange.vue'

defineProps({
  name: String,
  employer: String,
  startDate: String,
  endDate: String,
  description: String,
})
</script>

<template>
  <LargeBoldText :text="name" />
  <p class="py-3">{{ employer }}</p>
  <DateRange :start-date="startDate" :end-date="endDate" />
  <p v-if="description != null" class="pt-2">
    {{ description }}
  </p>
</template>
