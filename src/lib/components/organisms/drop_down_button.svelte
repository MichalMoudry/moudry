<script>
  import IconButton from '../molecules/icon_button.svelte'

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
    } else {
      displayClass = 'hidden'
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
    id={buttonId}
    onClick={displayDropdown}
  />

  <div
    class="absolute {displayClass} bg-white right-0 z-10 origin-top-right rounded-md shadow-lg w-56 ring-1 ring-black ring-opacity-5"
    role="menu"
    aria-orientation="vertical"
    aria-labelledby={buttonId}
    tabindex="-1"
  >
    <div class="py-1" role="none">
      <slot />
    </div>
  </div>
</div>
