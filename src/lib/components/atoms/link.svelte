<script>
  /**
   * @type {String}
   */
  export let url

  /**
   * @type {String}
   */
  export let title

  /**
   * @type {String}
   */
  export let content

  /**
   * @type {String}
   */
  export let classes = ''
</script>

<a href="https://www.{url}" {title} class="text-blue-800 {classes}">{content}</a>
