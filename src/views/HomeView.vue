<script setup>
import { RouterLink } from 'vue-router'
import Card from '@/components/atoms/Card.vue'
import EduListItem from '@/components/molecules/EduListItem.vue'
import IconHeader from '@/components/molecules/IconHeader.vue'
import OssContributionListItem from '@/components/molecules/OssContributionListItem.vue'
import WorkExpListItem from '@/components/molecules/WorkExpListItem.vue'
import IconButton from '@/components/molecules/IconButton.vue'
</script>

<template>
  <Card id="about-card">
    <IconHeader icon="browser" text="About" />
    <p>
      IT Student and .NET developer. Nowadays, working mostly in C# and .NET ecosystem developing
      web services and other types of applications. Currently, I am learning Go, C++, Vue.js and
      Powershell.
    </p>
  </Card>

  <Card class="mt-4" id="work-experience-card">
    <IconHeader icon="briefcase" text="Work Experience" />
    <WorkExpListItem
      position=".NET Developer"
      employer="Ciklum Western Europe"
      start-date="Jul 2022"
    />
    <hr class="my-4" />
    <WorkExpListItem
      position="Technology Support Administrator"
      employer="IBM, Czech Republic"
      start-date="Jun 2020"
      end-date="Aug 2021"
      description="Working with an ECM system and its separate system for document digitalization (Datacap). Part of this work included development of a COM library for integrating Datacap with an ECM system through a SOAP API."
    />
    <hr class="my-4" />
    <WorkExpListItem
      position="Service Technician/Web developer"
      employer="Zettabyte IT, London"
      start-date="Feb 2017"
      end-date="Feb 2017"
      description="Working in a computer repair shop, where my primary responsibility was to repair computers. Additionally, I contributed to their internal web application, that was written in PHP language."
    />
  </Card>

  <Card class="mt-4">
    <IconHeader icon="monitor" text="Education" />
    <EduListItem
      school-name="Vysoká škola ekonomická v Praze"
      start-date="2021"
      end-date="2024"
      id="vse2"
      school-url="vse.cz"
      detail-url="/vse2"
    >
      <p>Two and a half year study of information systems and technologies.</p>
    </EduListItem>
    <hr class="my-4" />
    <EduListItem
      school-name="Vysoká škola ekonomická v Praze"
      start-date="2018"
      end-date="2021"
      id="vse1"
      school-url="vse.cz"
      detail-url="/vse1"
    >
      <p>Three-year study of applied informatics.</p>
    </EduListItem>
    <hr class="my-4" />
    <EduListItem
      school-name="Střední průmyslová škola na Proseku"
      start-date="2014"
      end-date="2018"
      id="sps"
      school-url="sps-prosek.cz"
      detail-url="/sps"
    >
      <p>
        Four-year study of information technology and computer science, ended with a graduation
        exam.
      </p>
    </EduListItem>
  </Card>

  <Card class="mt-4">
    <IconHeader icon="sun" text="Skills" />

    <div class="grid grid-rows-1 grid-cols-2">
      <ul>
        <li class="border-b pb-1">C#</li>
        <li class="border-b py-1">XAML</li>
        <li class="border-b py-1">PHP</li>
        <li class="border-b py-1">EF Core</li>
        <li class="border-b py-1">ReactJS</li>
        <li class="pt-1">UWP</li>
      </ul>
      <ul>
        <li class="border-b pb-1">Python</li>
        <li class="border-b py-1">Go</li>
        <li class="border-b py-1">HTML</li>
        <li class="border-b py-1">CSS</li>
        <li class="border-b py-1">UML</li>
        <li class="pt-1">Power BI</li>
      </ul>
    </div>
    <RouterLink to="/skills" class="mt-4 w-full" title="View skills page">
      <IconButton icon="chevron-right" content="More skills" class="w-full" />
    </RouterLink>
  </Card>

  <Card class="mt-4">
    <IconHeader icon="lightbulb" text="Open source contributions" />
    <OssContributionListItem
      name="Ambie"
      url="github.com/jenius-apps/ambie"
      description="A modern Windows app that plays soothing tones to help you be healthier, happier, and more relaxed."
    />
    <hr class="my-4" />
    <OssContributionListItem name="Nunit - docs" url="github.com/nunit/docs" description="." />
  </Card>

  <Card class="mt-4">
    <IconHeader icon="globe" text="Languages" />

    <p class="font-bold">Czech</p>
    <p>Native or bilingual speaker knowledge</p>
    <hr class="my-4" />

    <p class="font-bold">English</p>
    <p>Knowledge enabling professional work</p>
    <hr class="my-4" />

    <p class="font-bold">German</p>
    <p>Basic knowledge</p>
  </Card>
</template>
