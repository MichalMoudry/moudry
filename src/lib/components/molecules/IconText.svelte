<script>
	import Icon from '../atoms/Icon.svelte';

	/**
	 * @type {{ icon: string, text: string }}
	 */
	let { icon, text } = $props();
</script>

<p>
	<Icon {icon} classes="me-2 text-xl" isPrimaryTheme={true} />
	{text}
</p>
