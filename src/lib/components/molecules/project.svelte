<script>
  import ProjectHeader from '../atoms/project_header.svelte'

  /**
   * @type {String}
   */
  export let header

  export let isFirst = false

  const marginTop = isFirst ? 'mt-2' : 'mt-6'
</script>

<div class={marginTop}>
  <ProjectHeader text={header} />
  <div class="px-5 pt-2 text-justify">
    <slot />
  </div>
</div>
