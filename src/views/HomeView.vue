<script setup>
import Button from "../components/atoms/Button.vue";
import Card from "../components/atoms/Card.vue";
</script>

<template>
  <main>
    <p>Test</p>
    <Card>
      <Button :ctn="Temp" />
    </Card>
  </main>
</template>
