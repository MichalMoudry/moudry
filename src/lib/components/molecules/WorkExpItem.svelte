<script>
	import DateRange from "./DateRange.svelte";

    /** @type {{name: string, employer: string, startDate: string, endDate: string?, description: string?, classes: string}} */
    let { name, employer, startDate, endDate = null, description = null, classes = '' } = $props();
</script>

<div class="{classes}">
    <p class="font-bold">{name}</p >
    <p class="pb-3 text-sm">{employer}</p>
    <DateRange {startDate} {endDate} />

    {#if description !== null}
      <p class="text-justify pt-3">{description}</p>
    {/if}
</div >