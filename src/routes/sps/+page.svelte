<script>
  import Card from '$lib/components/atoms/card.svelte'
  import DateRangeDisplay from '$lib/components/atoms/date_range_display.svelte'
  import IconHeader from '$lib/components/molecules/icon_header.svelte'
  import Project from '$lib/components/molecules/project.svelte'
</script>

<Card>
  <IconHeader icon="monitor" text="Střední průmyslová škola na Proseku" />
  <DateRangeDisplay startDate="2014" endDate="2018" />
  <p>Four-year study ended with a graduation exam.</p>
</Card>

<Card classes="mt-4">
  <IconHeader icon="briefcase" text="Projects & other work" />

  <Project header="Graduation work" isFirst={true}>
    <p>
      Goal of this work is creation of Universal Windows Application (UWA) for finance management,
      whose main features are recording finances, ability to categorize finances and synchronization
      of data across multiple devices through cloud service.
    </p>
    <p class="mt-2">
      Text part of the work is about development on UWP, which includes UWP itself, .NET platform
      (including application models, .NET Standard and .NET Foundation), Azure cloud platform and
      NuGet distribution system.
    </p>
  </Project>

  <Project header="UWP To-do app">
    <p>To-do application for Windows 10. Built as Universal Windows Application.</p>
    <p><b>Features</b>:</p>
    <ul>
      <li>Adding list with to-dos</li>
      <li>Displaying list progress</li>
      <li>Adding to-dos</li>
      <li>Managing subtasks in a to-do</li>
    </ul>
  </Project>

  <Project header="Wordpress plugin">
    <p>Plugin for Wordpress for work assignment.</p>
    <p><b>Features</b>:</p>
    <ul>
      <li>Assigning work to users</li>
      <li>Management of assigned work</li>
      <li>Option for optional work</li>
    </ul>
  </Project>
</Card>
