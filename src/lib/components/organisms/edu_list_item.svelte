<script>
	import DateRangeDisplay from '../atoms/date_range_display.svelte';
	import LargeBoldText from '../atoms/large_bold_text.svelte';
	import DropDownButton from './drop_down_button.svelte';

	/**
	 * @type {String}
	 */
	export let name;

	/**
	 * @type {String}
	 */
	export let startDate;

	/**
	 * @type {String}
	 */
	export let endDate;

	/**
	 * @type {String}
	 */
	export let id;

	/**
	 * @type {String}
	 */
	export let url;
</script>

<div {id}>
	<div class="flex justify-between items-center">
		<LargeBoldText text={name} />
		<DropDownButton title="View menu" buttonId="{id}_dropdown">
			<a href="https://www.{url}" title="School site" class="block py-2 px-3 hover:bg-primary-300"
				>School site</a
			>
		</DropDownButton>
	</div>
	<DateRangeDisplay {startDate} {endDate} />
	<slot />
</div>
