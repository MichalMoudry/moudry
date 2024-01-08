<script setup>
import Card from '@/components/atoms/Card.vue';
import DateRange from '@/components/atoms/DateRange.vue';
import IconHeader from '@/components/molecules/IconHeader.vue';
import Project from '@/components/molecules/Project.vue';
import Link from '@/components/atoms/Link.vue';
</script>

<template>
    <Card>
        <IconHeader icon="monitor" text="Střední průmyslová škola na Proseku" id="page-header" />
        <DateRange start-date="2014" end-date="2018" />
        <p>Four-year study ended with a graduation exam.</p>
    </Card>

    <Card class="mt-4">
        <IconHeader icon="briefcase" text="Projects & other work" />

        <Project header="Graduation work" :is-first="true">
            <p>
                Goal of this work is creation of Universal
                Windows Application (UWA) for finance
                management, whose main features are
                recording finances, ability to categorize
                finances and synchronization of data across
                multiple devices through cloud service.
            </p>
            <p>
                Text part of the work is about development
                on UWP, which includes UWP itself, .NET
                platform (including application models, .NET
                Standard and .NET Foundation), Azure cloud
                platform and NuGet distribution system.
            </p>
        </Project>

        <Project header="UWP To-do app">
            <p>
                To-do application for Windows 10. Built as
                Universal Windows Application.
            </p>
            <p><b>Features</b>:</p>
            <ul class="list-disc ms-10">
                <li>Adding list with to-dos</li>
                <li>Displaying list progress</li>
                <li>Adding to-dos</li>
                <li>Managing subtasks in a to-do</li>
            </ul>
            <Link url="https://github.com/MichalMoudry/UWP-TodoApp" content="GitHub repository" />
        </Project>

        <Project header="Wordpress plugin">
            <p>Plugin for Wordpress for work assignment.</p>
            <p><b>Features</b>:</p>
            <ul class="list-disc ms-10">
                <li>Assigning work to users</li>
                <li>Management of assigned work</li>
                <li>Option for optional work</li>
            </ul>
        </Project>
    </Card>
</template>