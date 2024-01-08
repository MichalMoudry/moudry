<script setup>
import Card from '../atoms/Card.vue'
import IconText from '../molecules/IconText.vue'
import Link from '../atoms/Link.vue'
</script>

<template>
  <Card :has-padding="false">
    <div class="relative">
      <img src="/profile-image.jpg" alt="Michal Moudrý" draggable="false" class="rounded-t" />
      <h1 class="text-3xl bg-primary-300 bg-opacity-80 bottom-0 ps-4 py-6 absolute w-full">
        Michal Moudrý
      </h1>
    </div>

    <div class="p-4">
      <IconText icon="home" text="Czechia" />
      <div class="flex flex-col mt-1">
        <Link
          url="linkedin.com/in/michal-moudry/"
          title="LinkedIn"
          content="LinkedIn"
          class="p-2 rounded mt-2 hover:bg-primary-300 hover:bg-opacity-80"
        />
        <Link
          url="twitter.com/MichalMoudry"
          title="Twitter"
          content="Twitter"
          class="p-2 rounded mt-2 hover:bg-primary-300 hover:bg-opacity-80"
        />
        <Link
          url="github.com/MichalMoudry"
          title="GitHub"
          content="GitHub"
          class="p-2 rounded mt-2 hover:bg-primary-300 hover:bg-opacity-80"
        />
      </div>
    </div>
  </Card>
</template>
