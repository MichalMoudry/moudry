<script>
	import Icon from "../atoms/Icon.svelte";
	import Pill from "../atoms/Pill.svelte";

    /** @type {{startDate: string, endDate: string?}} */
    let { startDate, endDate } = $props();
</script>

<p>
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