<script setup>
import Card from "../atoms/Card.vue";
import Separator from "../atoms/Separator.vue";
import IconHeader from "../molecules/IconHeader.vue";
import EduList from "../templates/EduList.vue";
import WorkExpList from "../templates/WorkExpList.vue";
</script>

<template>
    <Card>
        <IconHeader icon="file-person" text="About" />
        <p>
            .NET developer and occasionally a security engineer. Nowadays, working mostly in C# and .NET
            ecosystem developing web services and other types of applications. Currently, I am learning Go,
            C++ and Powershell.
        </p>
    </Card>

    <Card class="mt-4">
        <IconHeader icon="briefcase" text="Work Experience" />
        <WorkExpList />
    </Card>

    <Card class="mt-4">
        <IconHeader icon="backpack4" text="Education" />
        <EduList />
    </Card>

    <Card class="mt-4">
        <IconHeader icon="sun" text="Skills" />
        <div class="grid grid-rows-1 grid-cols-2">
            <ul>
                <li class="border-b border-dashed pb-2 border-slate-400">C#</li>
                <li class="border-b border-dashed mt-2 pb-2 border-slate-400">Go</li>
                <li class="border-b border-dashed mt-2 pb-2 border-slate-400">UML</li>
                <li class="border-b border-dashed mt-2 pb-2 border-slate-400">EF Core</li>
                <li class="mt-2">UWP</li>
            </ul>
            <ul>
                <li class="border-b border-dashed pb-2 border-slate-400">Python</li>
                <li class="border-b border-dashed mt-2 pb-2 border-slate-400">F#</li>
                <li class="border-b border-dashed mt-2 pb-2 border-slate-400">ReactJS</li>
                <li class="border-b border-dashed mt-2 pb-2 border-slate-400">HTML & CSS</li>
                <li class="mt-2">Power BI</li>
            </ul>
        </div>
        <!--See more button-->
    </Card>

    <Card class="mt-4">
        <IconHeader icon="globe" text="Languages" />
        <p class="font-bold">Czech</p>
        <p>Native or bilingual speaker knowledge</p>
        <Separator/>

        <p class="font-bold">English</p>
        <p>Knowledge enabling professional work</p>
    </Card>
</template>