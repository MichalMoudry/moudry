<script>
  import DateRange from "./date_range.svelte"
  import DropDownButton from "./drop_down_button.svelte"

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
        <DropDownButton title="View menu" buttonId="{id}_dropdown">
            <a href="https://www.{url}" title="School site" class="block py-2 px-3 hover:bg-primary-300">
                School site
            </a>
        </DropDownButton>
    </div>
    <div class="py-2">
        <DateRange {startDate} {endDate} />
    </div>

    <slot />
</div>