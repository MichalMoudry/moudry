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

    /**
     * @type {boolean}
    */
    export let isFullWidth = false

    let background = bgColor ?? "bg-white"

    let width = isFullWidth ? "w-full" : ""
</script>

<button class="border border-black py-1 px-2 button-shadow {background} {width} hover:bg-black hover:text-white" type="button" on:click={onClick} title={title}>
    {content}
</button>