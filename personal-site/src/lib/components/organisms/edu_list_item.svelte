<script>
	import DateRangeDisplay from "../atoms/date_range_display.svelte";
    import LargeBoldText from "../atoms/large_bold_text.svelte";
	import IconButton from "../molecules/icon_button.svelte";

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

    function displayDrowdown() {
        alert("test");
    }
</script>

<div>
    <div class="flex justify-between items-center">
        <LargeBoldText text={name} />
        <IconButton icon="ellipses" content="" placement={0} classes="h-7" onClick={displayDrowdown} />
    </div>
    <DateRangeDisplay startDate={startDate} endDate={endDate} />
    <slot />
</div>
