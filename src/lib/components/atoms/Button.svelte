<script>
    /** @type {{content: string, title: string, onClick: (() => void)?, bgColor: string?, isFullWidth: boolean}} */
    let { content, title, onClick, bgColor, isFullWidth = false } = $props();

    let background = bgColor ?? "bg-white"

    let width = isFullWidth ? "w-full" : ""
</script>

<button class="border border-black py-1 px-2 button-shadow {background} {width} hover:bg-black hover:text-white" type="button" onclick="{onClick}" title={title}>
    {content}
</button>