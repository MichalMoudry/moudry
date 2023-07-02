<script>
    /**
     * @type {String}
     */
    export let classes = "";

    /**
     * @type {String?}
     */
    export let content = null;
</script>

<button class="border-primary-300 border rounded py-1 px-2 {classes} hover:bg-primary-300">
    {#if content != null}
        <span>{content}</span>
    {:else}
        <slot />
    {/if}
</button>