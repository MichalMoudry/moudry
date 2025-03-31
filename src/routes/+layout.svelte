<script>
    import '../app.css'

    let { children } = $props();
</script>

<main class="py-8 px-6 min-h-screen flex justify-center">
    {@render children?.()}
</main>

<footer class="bg-primary-300 p-3 w-full flex justify-center">
    <p>Powered by SvelteKit and Open Iconic.</p>
</footer>