<script>
	import LargeBoldText from "../atoms/LargeBoldText.svelte";
	import DateRange from "../molecules/DateRange.svelte";
	import DropDownButton from "../molecules/DropDownButton.svelte";

    /**
     * @type {{ id: string, name: string, startDate: string, endDate: string, url: string, children: any }}
     */
    let { id, name, startDate, endDate, url, children } = $props();
</script>

<div {id}>
    <div class="flex justify-between items-center">
      <LargeBoldText text={name} />
      <DropDownButton title="View menu" id="{id}_dropdown">
        <a href="https://www.{url}" title="School site" class="block py-2 px-3 hover:bg-primary-300"
          >School site</a
        >
        <a href="/{id}" title="More details" class="block py-2 px-3 hover:bg-primary-300"
          >More details</a
        >
      </DropDownButton>
    </div>
    <div class="my-3">
      <DateRange {startDate} {endDate} />
    </div>
    {@render children?.()}
  </div>