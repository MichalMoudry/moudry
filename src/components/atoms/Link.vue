<script setup>
    const props = defineProps({
        url: String,
        content: String
    })
    const formattedUrl = `https://${props.url}`
</script>

<template>
    <a :href="formattedUrl" class="hover:underline text-blue-800">
        {{ content }}
    </a>
</template>