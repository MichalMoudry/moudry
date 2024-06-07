<script>
	export let classes = '';

	/**
	 * Setting for indicating a default padding of the card.
	 *
	 * @type {boolean}
	 */
	export let hasPadding = true;

	const padding = hasPadding ? 'p-6' : '';
</script>

<div class="bg-white rounded-md {padding} shadow {classes}">
	<slot />
</div>
