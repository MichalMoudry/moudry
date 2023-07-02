<script>
	import Button from "../atoms/button.svelte";
	import Icon from "../atoms/icon.svelte";

    /**
     * @type {String}
     */
    export let classes = "";

    /**
     * @type {String}
     */
    export let content;

    /**
     * @type {number}
     */
    export let placement;
</script>

<Button classes="{classes}">
    {#if placement === 0}
        <Icon icon="chevron-right" />
        <span>{content}</span>
    {:else if placement === 1}
        <span>{content}</span>
        <Icon icon="chevron-right" />
    {/if}
</Button>