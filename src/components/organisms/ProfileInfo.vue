<script setup>
import Card from "../atoms/Card.vue";
import IconText from '../molecules/IconText.vue';
import Link from '../atoms/Link.vue';
</script>

<template>
    <Card :has-padding="false">
        <div class="relative">
            <img src="/profile-image.jpg" alt="Michal Moudrý" draggable="false" class="rounded-t" />
            <h1 class="text-3xl bg-primary-300 opacity-80 bottom-0 ps-4 py-4 absolute w-full">
                Michal Moudrý
            </h1>
        </div>

        <div class="p-4">
            <IconText icon="house" text="Czechia" />
            <div class="flex flex-col mt-1">
            </div>
        </div>
    </Card>
</template>