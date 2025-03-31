<script>
	import Link from "../atoms/Link.svelte";

    /** @type {{name: string, description: string, url: string, classes: string}} */
    let { name, description, url, classes = '' } = $props();
</script>

<div class="{classes}">
    <span class="font-bold">{name}</span>
    <p class="py-1">{description}</p>
    <p>Link: <Link {url} title="Link to {name} project" content="Link" /></p>
</div>