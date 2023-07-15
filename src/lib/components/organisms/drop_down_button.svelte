<script>
	import IconButton from "../molecules/icon_button.svelte";

	/**
     * @type {String}
     */
	export let title;

	/**
	 * @type {String}
	 */
	export let id;
</script>

<div class="relative inline-block text-left">
	<IconButton icon="ellipses" classes="border-0" placement={1} content="" title={title} id={id} />

	<div role="menu" aria-orientation="vertical">
		<div class="py-1" role="none">
			<slot />
		</div>
	</div>
</div>