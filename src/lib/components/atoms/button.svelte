<script>
    /**
    * A string that will be used as button's content.
    * @type {String}
    */
    export let content;

    /**
    * @type {(() => void)?}
    */
    export let onClick = null
</script>

<button class="border border-black py-1 px-2 button-shadow hover:bg-black hover:text-white" type="button" onclick={onClick}>
    {content}
</button  >