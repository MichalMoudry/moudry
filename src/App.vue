<script setup>
import ProfileInfo from './components/organisms/ProfileInfo.vue'
import Home from './components/pages/Home.vue'
</script>

<template>
  <main class="md:p-4 flex justify-center">
    <div class="grid container gap-4 grid-cols-1 md:grid-cols-3">
      <div>
        <ProfileInfo />
      </div>

      <div class="w-full col-span-1 md:col-span-2">
        <Home />
      </div>
    </div>
  </main>

  <!--
  <footer class="bg-primary-300 p-4 w-full flex justify-center">
    <p>
      Powered by
      <Link url="#" title="Open Iconic" content="Open Iconic" /> and
      <Link url="#" title="Vue.js" content="Vue.js" />
    </p>
  </footer>
  -->
</template>
