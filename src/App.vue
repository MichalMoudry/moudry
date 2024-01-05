<script setup>
import { RouterView } from 'vue-router'
import Link from './components/atoms/Link.vue';
import ProfileInformation from './components/organisms/ProfileInformation.vue';
</script>

<template>
  <main class="p-4 flex justify-center">
    <div class="grid container gap-4 grid-cols-1 md:grid-cols-3">
      <div>
        <ProfileInformation />
      </div>

      <div class="w-full col-span-1 md:col-span-2">
        <RouterView />
      </div>
    </div>
  </main>

  <footer class="bg-primary-300 p-4 w-full flex justify-center">
    <p>
      Powered by
      <Link url="#" title="Open Iconic" content="Open Iconic" /> and
      <Link url="#" title="Vue.js" content="Vue.js" />
    </p>
  </footer>
</template>
