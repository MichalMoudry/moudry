<script setup>
    const props = defineProps({
        content: String
    })
</script>

<template>
    <button class="border-primary-300 border rounded py-1 px-2 hover:bg-primary-300">
        <span>{{ props.content }}</span>
    </button>
</template>