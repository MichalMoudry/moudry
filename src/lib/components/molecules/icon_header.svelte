<script>
  import Icon from '../atoms/icon.svelte'

  /**
   * @type {String}
   */
  export let icon

  /**
   * @type {String}
   */
  export let text
</script>

<h2 class="flex items-center mb-3 font-bold">
  <Icon {icon} isPrimaryTheme={false} classes="me-4 text-3xl" />
  <span>{text}</span>
</h2>