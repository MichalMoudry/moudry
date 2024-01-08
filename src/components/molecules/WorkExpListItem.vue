<script setup>
import DateRange from '../atoms/DateRange.vue'
import LargeBoldText from '../atoms/LargeBoldText.vue'

const prop = defineProps({
  position: String,
  employer: String,
  startDate: String,
  endDate: {
    type: String,
    required: false
  },
  description: {
    type: String,
    required: false
  }
})
</script>

<template>
  <LargeBoldText :text="position" />
  <p class="py-2">{{ employer }}</p>
  <DateRange :start-date="startDate" :end-date="endDate" />
  <p v-if="description != undefined" class="text-justify">{{ description }}</p>
</template>
