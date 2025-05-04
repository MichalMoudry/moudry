<script setup>
const props = defineProps({
    url: String,
    content: String
})
</script>

<template>
    <a :href="props.url">
        {{ content }}
    </a>
</template>