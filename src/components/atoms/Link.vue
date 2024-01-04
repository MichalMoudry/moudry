<script setup>
    const props = defineProps({
        url: String,
        title: String,
        content: String
    })
    const formattedUrl = `https://${props.url}`
</script>

<template>
    <a :href="formattedUrl" :title="title" class="hover:underline text-blue-800">
        {{ content }}
    </a>
</template>