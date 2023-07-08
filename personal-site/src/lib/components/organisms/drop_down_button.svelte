<script>
	import IconButton from "../molecules/icon_button.svelte";

	/**
     * @type {String}
     */
	export let title;
</script>

<IconButton icon="ellipses" classes="border-0" placement={1} content="" title={title} />