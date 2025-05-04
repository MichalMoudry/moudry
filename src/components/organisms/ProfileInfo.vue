<script setup>
import Card from '../atoms/Card.vue'
import Link from '../atoms/Link.vue'
import IconText from '../molecules/IconText.vue'
</script>

<template>
  <Card :has-padding="false">
    <div class="relative">
      <img
        src="/profile-image.jpg"
        alt="Michal Moudrý"
        draggable="false"
        class="rounded-t lazyload"
      />
      <h1 class="text-3xl bg-primary-300 opacity-80 bottom-0 p-4 absolute w-full">Michal Moudrý</h1>
    </div>

    <div class="p-4">
      <IconText icon="house" text="Czechia" />
      <div class="flex flex-col mt-2">
        <Link url="linkedin.com/in/michal-moudry/" title="LinkedIn" class="mt-2">
          <IconText icon="linkedin" text="LinkedIn" />
        </Link>
        <Link url="github.com/MichalMoudry" title="GitHub" class="mt-2">
          <IconText icon="github" text="GitHub" />
        </Link>
        <Link url="bsky.app/profile/michalmoudry.bsky.social" title="Bluesky" class="mt-2">
          <IconText icon="bluesky" text="Bluesky" />
        </Link>
      </div>
    </div>
  </Card>
</template>
