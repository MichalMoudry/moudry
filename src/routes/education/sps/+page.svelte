<script>
	import Card from "$lib/components/atoms/card.svelte";
	import DateRangeDisplay from "$lib/components/atoms/date_range_display.svelte";
	import Link from "$lib/components/atoms/link.svelte";
	import IconText from "$lib/components/molecules/icon_text.svelte";
	import Project from "$lib/components/molecules/project.svelte";
</script>

<Card>
    <h2 class="font-bold text-2xl">Střední průmyslová škola na Proseku</h2>
    <DateRangeDisplay startDate="2014" endDate="2018" />
    <p class="mb-2">Four-year study ended with a graduation exam.</p>
    <Link url="sps-prosek.cz" title="SPŠ na Proseku" content="School website" />
</Card>

<Card classes="mt-4">
    <h3 class="font-bold text-xl">
        <IconText icon="briefcase" text="Projects & other work" />
    </h3>

    <Project header="Graduation work" isFirst={true}>
        <p>
            Goal of this work is creation of Universal
            Windows Application (UWA) for finance
            management, whose main features are
            recording finances, ability to categorize
            finances and synchronization of data across
            multiple devices through cloud service.
        </p>
        <p class="mt-2">
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
        <p><u>Features</u>:</p>
        <ul class="list-disc list-inside">
            <li>Adding list with to-dos</li>
            <li>Displaying list progress</li>
            <li>Adding to-dos</li>
            <li>Managing subtasks in a to-do</li>
        </ul>
    </Project>

    <Project header="Wordpress plugin">
        <p>Plugin for Wordpress for work assignment.</p>
        <p><u>Features</u>:</p>
        <ul class="list-disc list-inside">
            <li>Assigning work to users</li>
            <li>Management of assigned work</li>
            <li>Option for optional work</li>
        </ul>
    </Project>
</Card>