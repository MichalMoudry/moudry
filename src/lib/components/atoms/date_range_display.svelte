<script>
	import Icon from './icon.svelte';
	import Pill from './pill.svelte';

	/**
	 * @type {String}
	 */
	export let startDate;

	/**
	 * @type {String?}
	 */
	export let endDate;
</script>

<p class="py-2">
	<Icon icon="calendar" classes="me-1" />
	<span class="text-primary-500">
		{startDate}
		-
		{#if endDate != null}
			{endDate}
		{:else}
			<Pill text="Now" />
		{/if}
	</span>
</p>
