<script>
	import LargeBoldText from '../atoms/large_bold_text.svelte';
	import Link from '../atoms/link.svelte';

	/**
	 * @type {String}
	 */
	export let name;

	/**
	 * @type {String}
	 */
	export let description;

	/**
	 * @type {String}
	 */
	export let url;
</script>

<LargeBoldText text={name} />
<p class="py-2">{description}</p>
<p>Link: <Link {url} title="Link to {name} project" content="Link" /></p>
