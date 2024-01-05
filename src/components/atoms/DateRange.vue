<script setup>
    import Icon from './Icon.vue';
    import Pill from './Pill.vue';

    const props = defineProps({
        startDate: String,
        endDate: {
            type: String,
            required: false
        }
    })
</script>

<template>
    <p class="py-2">
        <Icon icon="calendar" class="me-2" />
        <span v-if="endDate !== undefined">{{ startDate }} - {{ endDate }}</span>
        <span v-else>{{ startDate }} - <Pill text="now" /></span>
    </p>
</template>