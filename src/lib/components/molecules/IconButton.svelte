<script>
	import { IconOrientation } from '$lib/model/icon-orientation';
	import Button from '../atoms/Button.svelte';
	import Icon from '../atoms/Icon.svelte';

	/**
	 * @type {{ id: string, title: string, icon: string, content: string, classes: string, placement: IconOrientation }}
	 */
	let { id, title, icon, content, classes = '', placement = IconOrientation.Left } = $props();
</script>

<Button classes="{classes} hover:text-white" {title} {id}>
	{#if placement == IconOrientation.Left}
		<Icon {icon} isPrimaryTheme={false} classes="" />
		<span>{content}</span>
	{:else if placement == IconOrientation.Right}
		<span>{content}</span>
		<Icon {icon} isPrimaryTheme={false} classes="" />
	{/if}
</Button>
