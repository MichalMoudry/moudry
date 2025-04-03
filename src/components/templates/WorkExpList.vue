<script setup>
import Separator from '../atoms/Separator.vue';
import WorkExpItem from '../organisms/WorkExpItem.vue';
</script>

<template>
    <div id="work-exp-list">
        <WorkExpItem
            name=".NET Developer"
            employer="Ciklum Czech Republic & Slovakia"
            start-date="Jul 2022"
            end-date="now"
            description="Working on a complex .NET solution as a full-stack developer. As part of this work, I am working on stuff ranging from implementation of new features, bug fixing, optimizations to security and compliance."
        />

        <Separator/>

        <WorkExpItem
            name="Technology Support Administrator"
            employer="IBM, Czech Republic"
            start-date="Jun 2020"
            end-date="Aug 2021"
            description="Worked with an ECM system and its separate system for document digitalization (Datacap). Part of this work included development of a COM library for integrating Datacap with the ECM system through a SOAP API."
        />

        <Separator/>

        <WorkExpItem
            name="Service Technician/Web developer"
            employer="Zettabyte IT, London"
            start-date="Feb 2017"
            end-date="Feb 2017"
            description="Worked in a computer repair shop, where my primary responsibility was to repair computers. Additionally, I contributed to their internal web application, that was written in PHP."
        />
    </div>
</template>