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

    /**
     * @type {String}
     */
    export let title;

    /**
     * @type {String?}
     */
    export let id = null;
</script>

<Button classes="{classes} hover:text-white" onClick={onClick} title={title}>
    {#if placement === 0}
        <Icon icon={icon} isPrimaryTheme={false} />
        <span>{content}</span>
    {:else if placement === 1}
        <span>{content}</span>
        <Icon icon={icon} isPrimaryTheme={false} />
    {/if}
</Button>