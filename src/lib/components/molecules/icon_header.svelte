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

  /**
   * @type {String}
  */
  export let id
</script>

<h2 id={id} class="flex items-center mb-3 font-bold">
  <Icon {icon} isPrimaryTheme={false} classes="me-4 text-3xl" />
  <span>{text}</span>
</h2>