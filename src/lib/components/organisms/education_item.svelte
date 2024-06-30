<script>
    /**
     * @type {String}
    */
    export let name

    /**
   * @type {String}
   */
    export let startDate

    /**
     * @type {String}
     */
    export let endDate

    /**
     * @type {String}
     */
    export let id

    /**
     * @type {String}
     */
    export let url

    /**
     * @type {String}
    */
    export let classes = ''
</script>

<div {id} class="{classes}">
    <div class="flex justify-between items-center">
        <span class="font-bold">{name}</span>
    </div>

    <slot />
</div>