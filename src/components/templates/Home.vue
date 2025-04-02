<script setup>
import Card from "../atoms/Card.vue";
import IconHeader from "../molecules/IconHeader.vue";
</script>

<template>
    <Card>
        <IconHeader icon="browser" text="About" />
    </Card>

    <Card class="mt-4">
        <IconHeader icon="monitor" text="Education" />
    </Card>

    <Card class="mt-4">
        <IconHeader icon="sun" text="Skills" />
    </Card>

    <Card class="mt-4">
        <IconHeader icon="lightbulb" text="OSS contributions" />
    </Card>

    <Card class="mt-4">
        <IconHeader icon="globe" text="Languages" />
    </Card>
</template>