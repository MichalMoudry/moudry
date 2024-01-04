<script setup>
    import Icon from "../atoms/Icon.vue"

    const props = defineProps({
        content: String,
        placement: Number,
        icon: String
    })
</script>

<template>
    <button>
        <Icon :icon="icon" />
        {{ content }}
    </button>
</template>