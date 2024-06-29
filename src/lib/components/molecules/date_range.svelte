<script>
  import Icon from '../atoms/icon.svelte'
  import Pill from '../atoms/pill.svelte'

  /**
   * @type {String}
   */
  export let startDate

  /**
   * @type {String?}
   */
  export let endDate
</script>

<p class="py-1">
  <Icon icon="calendar" classes="me-1" />
  <span>
    {startDate}
    -
    {#if endDate != null}
      {endDate}
    {:else}
      <Pill text="Now" />
    {/if}
  </span>
</p>