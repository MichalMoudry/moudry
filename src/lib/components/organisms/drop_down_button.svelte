<script>
	import IconButton from "../molecules/icon_button.svelte";

	/**
     * @type {String}
     */
	export let title;
</script>

<div class="relative inline-block text-left">
	<IconButton icon="ellipses" classes="border-0" placement={1} content="" title={title} />

	<div role="menu">
		<div class="py-1" role="none">
			<slot />
		</div>
	</div>
</div>