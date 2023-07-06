<script>
    /**
     * @type {String}
     */
    export let classes = "";

    /**
     * @type {String?}
     */
    export let content = null;

    /**
     * @type {(() => void)?}
     */
    export let onClick = null;
</script>

<button class="border-primary-300 border rounded py-1 px-2 {classes} hover:bg-primary-300" on:click={onClick}>
    {#if content != null}
        <span>{content}</span>
    {:else}
        <slot />
    {/if}
</button>