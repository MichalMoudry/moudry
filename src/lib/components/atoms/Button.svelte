<script>
    let { id, children, title, classes = '' } = $props();
</script>

<button class="border-primary-300 border rounded py-1 px-2 {classes} hover:bg-primary-400" {title} {id}>
    {@render children?.()}
</button>