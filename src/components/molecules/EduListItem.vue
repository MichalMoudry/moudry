<script setup>
    import LargeBoldText from '../atoms/LargeBoldText.vue';
    import DateRange from '../atoms/DateRange.vue';
    import DropdownButton from './DropdownButton.vue';

    const props = defineProps({
        schoolName: String,
        startDate: String,
        endDate: String,
        schoolUrl: String
    })

    const formattedUrl = `https://${props.schoolUrl}`
</script>

<template>
    <div>
        <div class="flex justify-between items-center">
            <LargeBoldText :text="schoolName" />
            <DropdownButton title="View menu">
                <a :href="formattedUrl" title="School's website" class="block py-2 px-3 hover:bg-primary-300">School's website</a>
            </DropdownButton>
        </div>
        <DateRange :start-date="startDate" :end-date="endDate" />
        <slot />
    </div>
</template>