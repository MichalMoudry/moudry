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

    /**
     * @type {String}
     */
    export let icon;

    /**
     * @type {(() => void)?}
     */
    export let onClick = null;
</script>

<Button classes="{classes}" onClick={onClick}>
    {#if placement === 0}
        <Icon icon={icon} />
        <span>{content}</span>
    {:else if placement === 1}
        <span>{content}</span>
        <Icon icon={icon} />
    {/if}
</Button>