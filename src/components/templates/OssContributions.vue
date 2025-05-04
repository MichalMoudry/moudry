<script setup>
import Separator from '../atoms/Separator.vue'
import OssContribListItem from '../molecules/OssContribListItem.vue'
</script>

<template>
  <div id="oss-contributions">
    <OssContribListItem name="Ambie" url="https://github.com/jenius-apps/ambie">
      <p>
        A modern Windows app that plays soothing tones to help you be healthier, happier, and more
        relaxed.
      </p>
    </OssContribListItem>

    <Separator />

    <OssContribListItem name="NUnit - docs" url="https://github.com/nunit/docs">
      <p>.</p>
    </OssContribListItem>
  </div>
</template>
