<script>
    /**
    * A string that will be used as button's content.
    * @type {String}
    */
    export let content;

    /**
     * @type {String}
    */
    export let title;

    /**
    * @type {(() => void)?}
    */
    export let onClick = null

    /**
     * @type {String?}
    */
    export let bgColor = null

    let background = bgColor ?? "bg-white"
</script>

<button class="border border-black py-1 px-2 button-shadow {background} hover:bg-black hover:text-white" type="button" on:click={onClick} title={title}>
    {content}
</button>