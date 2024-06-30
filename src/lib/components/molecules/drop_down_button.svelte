<script>
  import Icon from "../atoms/icon.svelte"

    /**
     * @type {String}
     */
    export let title

    /**
     * @type {String}
     */
    export let buttonId

    /**
     * @type {String}
     */
    let displayClass = 'hidden'

    function displayDropdown() {
        if (displayClass == 'hidden') {
            displayClass = 'block'
        }
        else {
            displayClass = 'hidden'
        }
    }
</script>

<div class="relative inline-block text-left">
    <button id={buttonId} title={title} on:click={displayDropdown} class="p-2"><Icon icon="ellipses" isPrimaryTheme={false} /></button>
    <div
        class="absolute {displayClass} bg-white right-0 z-10 origin-top-right border border-black shadow-lg w-56 ring-1 ring-black ring-opacity-5"
        role="menu"
        aria-orientation="vertical"
        aria-labelledby={buttonId}
        tabindex="-1">
        <div class="py-1" role="none">
            <slot />
        </div>
    </div>
</div>