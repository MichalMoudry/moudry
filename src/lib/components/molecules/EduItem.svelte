<script>
	import DateRange from "./DateRange.svelte";
	import DropDownButton from "./DropDownButton.svelte";

    /** @type {{ name: string, startDate: string, endDate: string, id: string, url: string, children: any, classes: string }} */
    let { name, startDate, endDate, id, url, children, classes = '' } = $props();
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

    {@render children?.()}
</div>