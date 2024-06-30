<script>
  import DateRange from '../molecules/date_range.svelte'

  /**
   * @type {String}
   */
  export let name

  /**
   * @type {String}
   */
  export let employer

  /**
   * @type {String}
   */
  export let startDate

  /**
   * @type {String?}
   */
  export let endDate = null

  /**
   * @type {String?}
   */
  export let description = null

  export let classes = '';
</script>

<div class="{classes}">
    <p class="font-bold">{name}</p >
    <p class="pb-3 text-sm">{employer}</p>
    <DateRange {startDate} {endDate} />

    {#if description !== null}
      <p class="text-justify pt-2">{description}</p>
    {/if}
</div >