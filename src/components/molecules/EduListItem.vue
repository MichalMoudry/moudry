<script setup>
    import LargeBoldText from '../atoms/LargeBoldText.vue';
    import DateRange from '../atoms/DateRange.vue';

    const props = defineProps({
        schoolName: String,
        startDate: String,
        endDate: String,
        schoolUrl: String
    })
</script>

<template>
    <div>
        <div class="flex justify-between items-center">
            <LargeBoldText :text="schoolName" />
        </div>
        <DateRange :start-date="startDate" :end-date="endDate" />
        <slot />
    </div>
</template>