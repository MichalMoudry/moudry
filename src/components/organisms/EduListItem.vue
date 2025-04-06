<script setup>
import LargeBoldText from '../atoms/LargeBoldText.vue';
import DateRange from '../molecules/DateRange.vue';

defineProps({
    name: String,
    startDate: String,
    endDate: String,
    url: String
})
</script>

<template>
    <div>
        <div class="flex justify-between items-center">
            <LargeBoldText :text="name" />
        </div>
        <div class="my-3">
            <DateRange :start-date="startDate" :end-date="endDate" />
        </div>
        <slot />
    </div>
</template>