<script>
	import LargeBoldText from '../atoms/LargeBoldText.svelte';
	import DateRange from '../molecules/DateRange.svelte';

	/**
	 * @type {{ name: string, employer: string, startDate: string, description: string, endDate: string? }}
	 */
	let { name, employer, startDate, description, endDate = null } = $props();
</script>

<LargeBoldText text={name} />

<p class="py-3">{employer}</p>

<DateRange {startDate} {endDate} />

{#if description !== null}
	<p class="text-justify pt-2">{description}</p>
{/if}
