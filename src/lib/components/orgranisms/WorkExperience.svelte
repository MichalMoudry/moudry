<script>
	import IconHeader from "../molecules/IconHeader.svelte";
	import WorkExpItem from "../molecules/WorkExpItem.svelte";
</script>

<IconHeader icon="briefcase" id="workexp" text="Work Experience" />

<WorkExpItem
    name=".NET Developer"
    employer="Ciklum Western Europe, Czech Republic"
   startDate="Jul 2022"
   description="Working on a .NET solution as a full-stack developer. As part of this work, I am working on stuff ranging from implementation of new features, bug fixing and optimizations." />

<WorkExpItem
    name="Technology Support Administrator"
    employer="IBM, Czech Republic"
    startDate="Jun 2020"
    endDate="Aug 2021"
    description="Worked with an ECM system and its separate system for document digitalization (Datacap). Part of this work included development of a COM library for integrating Datacap with the ECM system through a SOAP API."
    classes="mt-6"
  />

<WorkExpItem
    name="Service Technician/Web developer"
    employer="Zettabyte IT, London"
    startDate="Feb 2017"
    endDate="Feb 2017"
    description="Worked in a computer repair shop, where my primary responsibility was to repair computers. Additionally, I contributed to their internal web application, that was written in PHP language."
    classes="mt-6"
  />