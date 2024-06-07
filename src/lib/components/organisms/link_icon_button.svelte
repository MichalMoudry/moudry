<script>
	import IconButton from '../molecules/icon_button.svelte';

	/**
	 * @type {String}
	 */
	export let content;

	/**
	 * @type {number}
	 */
	export let placement = 1;

	/**
	 * @type {String}
	 */
	export let icon;

	/**
	 * @type {String}
	 */
	export let url;

	/**
	 * @type {String}
	 */
	export let classes = '';

	/**
	 * @type {String}
	 */
	export let title;
</script>

<a href={url} title="Link to {content}">
	<IconButton {icon} {content} {placement} {classes} {title} />
</a>
