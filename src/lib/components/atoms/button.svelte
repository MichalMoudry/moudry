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

    /**
     * @type {String}
     */
    export let title;

    /**
     * @type {String?}
     */
    export let id = null;
</script>

{#if id != null}
<button class="border-primary-300 border rounded py-1 px-2 {classes} hover:bg-primary-400" on:click={onClick} title={title} id="{id}">
    {#if content != null}
        <span>{content}</span>
    {:else}
        <slot />
    {/if}
</button>
{:else}
<button class="border-primary-300 border rounded py-1 px-2 {classes} hover:bg-primary-400" on:click={onClick} title={title}>
    {#if content != null}
        <span>{content}</span>
    {:else}
        <slot />
    {/if}
</button>
{/if}