<script setup>
const props = defineProps({
    url: String,
    content: String
})
const formattedUrl = `https://${props.url}`
</script>

<template>
    <a :href="formattedUrl">
        {{ content }}
    </a>
</template>