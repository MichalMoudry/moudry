<script>
	import LargeBoldText from "../atoms/LargeBoldText.svelte";
	import Link from "../atoms/Link.svelte";

    /**
     * @type {{ name: string, description: string, url: string }}
     */
    let { name, description, url } = $props();
</script>

<LargeBoldText text={name} />
<p class="py-2">{description}</p>
<p>Link: <Link {url} title="Link to {name} project" content="Link" classes='' /></p>