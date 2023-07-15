<script>
	import DateRangeDisplay from "../atoms/date_range_display.svelte";
    import LargeBoldText from "../atoms/large_bold_text.svelte";
	import DropDownButton from "./drop_down_button.svelte";

    /**
     * @type {String}
     */
    export let name;

    /**
     * @type {String}
     */
    export let startDate;

    /**
     * @type {String}
     */
    export let endDate;

    /**
     * @type {String}
     */
    export let id;
</script>

<div id="{id}">
    <div class="flex justify-between items-center">
        <LargeBoldText text={name} />
        <DropDownButton title="View menu" buttonId="{id}_dropdown">
            <a href="./" title="Test 1" class="block p-4 text-sm hover:bg-primary-300">School site</a>
            <a href="./" title="Test 2" class="block p-4 text-sm hover:bg-primary-300">More details</a>
        </DropDownButton>
    </div>
    <DateRangeDisplay startDate={startDate} endDate={endDate} />
    <slot />
</div>
