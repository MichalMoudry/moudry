<script>
	import Header from '../atoms/Header.svelte';

	/**
	 * @type {{ header: string, children: any, isFirst: boolean }}
	 */
	let { header, children, isFirst = false } = $props();

	const marginTop = isFirst ? 'mt-2' : 'mt-6';
</script>

<div class={marginTop}>
	<Header text={header} />
	<div class="px-5 pt-2 text-justify">
		{@render children?.()}
	</div>
</div>
