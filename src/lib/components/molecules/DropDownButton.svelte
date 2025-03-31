<script>
	import Icon from "../atoms/Icon.svelte";

    /** @type {{title: string, buttonId: string, children: any}} */
    let { title, buttonId, children } = $props();

    let displayClass = $state('hidden');

    function toggleDisplay() {
        if (displayClass == 'hidden') {
            displayClass = 'block';
        }
        else {
            displayClass = 'hidden';
        }
    }
</script>

<div class="relative inline-block text-left">
    <button id={buttonId} title={title} onclick={() => toggleDisplay()} class="p-2">
        <Icon icon="ellipses" isPrimaryTheme={false} />
    </button>

    <div
        class="absolute {displayClass} bg-white right-0 z-10 origin-top-right border border-black shadow-lg w-56 ring-1 ring-black ring-opacity-5"
        role="menu"
        aria-orientation="vertical"
        aria-labelledby={buttonId}
        tabindex="-1">
        <div class="py-1" role="none">
            {@render children?.()}
        </div>
    </div>
</div>