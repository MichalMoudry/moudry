<script>
    import Link from '../atoms/link.svelte'

    /**
     * @type {String}
     */
    export let name

    /**
     * @type {String}
     */
    export let description

    /**
     * @type {String}
     */
    export let url

    /**
     * @type {String}
    */
    export let classes = ''
</script>

<div class="{classes}">
    <span class="font-bold">{name}</span>
    <p class="py-1">{description}</p>
    <p>Link: <Link {url} title="Link to {name} project" content="Link" /></p>
</div>