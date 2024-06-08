<script>
  import DateRangeDisplay from '../atoms/date_range_display.svelte'
  import LargeBoldText from '../atoms/large_bold_text.svelte'

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
</script>

<LargeBoldText text={name} />

<p class="py-3">{employer}</p>

<DateRangeDisplay {startDate} {endDate} />

{#if description !== null}
  <p class="text-justify pt-2">{description}</p>
{/if}
