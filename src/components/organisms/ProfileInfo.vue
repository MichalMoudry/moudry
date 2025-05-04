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
                <Link
                    url="linkedin.com/in/michal-moudry/"
                    title="LinkedIn"
                    content="LinkedIn"
                    class="rounded mt-2"
                />
                <Link
                    url="github.com/MichalMoudry"
                    title="GitHub"
                    content="GitHub"
                    class="rounded mt-2"
                />
                <Link
                    url="bsky.app/profile/michalmoudry.bsky.social"
                    title="Bluesky"
                    content="Bluesky"
                    class="rounded mt-2"
                />
            </div>
        </div>
    </Card>
</template>