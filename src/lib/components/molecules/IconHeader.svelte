<script>
	import Icon from '../atoms/Icon.svelte';

	/**
	 * @type {{ icon: string, text: string }}
	 */
	let { icon, text } = $props();
</script>

<h2 class="flex items-center mb-4">
	<Icon {icon} classes="me-4 text-3xl" isPrimaryTheme={true} />
	<span class="text-2xl">{text}</span>
</h2>
