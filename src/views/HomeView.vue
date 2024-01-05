<script setup>
import Button from "../components/atoms/Button.vue";
import Card from "../components/atoms/Card.vue";
import Icon from "@/components/atoms/Icon.vue";
import LargeBoldText from "@/components/atoms/LargeBoldText.vue";
import Link from "@/components/atoms/Link.vue";
import IconButton from "@/components/molecules/IconButton.vue"
import IconHeader from "@/components/molecules/IconHeader.vue";
import IconText from "@/components/molecules/IconText.vue";
import Project from "@/components/molecules/Project.vue";
import ProfileInformation from "@/components/organisms/ProfileInformation.vue"
import OssContributionListItem from "@/components/molecules/OssContributionListItem.vue";
import DateRange from "@/components/atoms/DateRange.vue";

/**
 * Function for displaying an alert.
 * @param {String} text - Text that will be in the alert.
 */
function alertCustom(text) {
  alert(text)
}
</script>

<template>
  <main>
    <p>Test</p>
    <Card>
      <Button content="Temp" id="test" title="Temp button" @click="alertCustom('Test ..')" />
      <Icon icon="beaker" />
      <LargeBoldText text="Large bold text" />
      <Link url="seznam.cz" title="Go to seznam.cz" content="seznam.cz" />
      <IconButton icon="aperture" content="recognition" title="Icon button" />
      <IconHeader icon="aperture" text="Icon Header" />
      <IconText icon="project" text="Icon text" />

      <hr />

      <Project header="Test project" is-first="true">
        <p>
          Test project description Test project description
        </p>
      </Project>
      <Project header="Test project 2">
        <p>
          Test project description Test project description
        </p>
      </Project>

      <hr class="my-5" />

      <ProfileInformation />
      <OssContributionListItem url="nunit.com" name="Nunit" description="Test description" />
      <DateRange start-date="2017" />
    </Card>
  </main>
</template>
