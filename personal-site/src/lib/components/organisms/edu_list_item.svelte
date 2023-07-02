<script>
	import DateRangeDisplay from "../atoms/date_range_display.svelte";
import LargeBoldText from "../atoms/large_bold_text.svelte";

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
</script>

<div>
    <LargeBoldText text={name} />
    <DateRangeDisplay startDate={startDate} endDate={endDate} />
    <slot />
</div>
