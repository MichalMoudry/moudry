<script>
	import IconButton from "./IconButton.svelte";

    /**
     * @type {{ id: string, title: string, children: any }}
     */
    let { id, title, children } = $props();

    let displayClass = $state('hidden');

    function toggleDropdown() {
        if (displayClass == 'hidden') {
            displayClass = 'block';
        }
        else if (displayClass == 'block') {
            displayClass = 'hidden';
        }
    }
</script>

<div class="relative inline-block text-left">
    <IconButton
        icon="ellipses"
        classes="border-0"
        placement={1}
        content=""
        {title}
        id={id}
    />

    <div
        class="absolute {displayClass} bg-white right-0 z-10 origin-top-right rounded-md shadow-lg w-56 ring-1 ring-black ring-opacity-5"
        role="menu"
        aria-orientation="vertical"
        aria-labelledby={id}
        tabindex="-1"
    >
        <div class="py-1" role="none">
            {@render children?.()}
        </div>
    </div>
</div>