<script>
	import ProfileInfo from "$lib/components/organisms/ProfileInfo.svelte";
    import '../app.css'

    let { children } = $props();
</script>

<main class="p-4 min-h-screen flex justify-center">
    <div class="grid container gap-4 grid-cols-1 md:grid-cols-4">
        <div>
            <ProfileInfo />
        </div>

        <div class="w-full col-span-2 sm:col-span-1 md:col-span-3">
            {@render children?.()}
        </div>
    </div>
</main>

<footer class="bg-primary-300 p-4 w-full flex justify-center">
    <p>Powered by SvelteKit, Tailwind CSS and Open Iconic.</p>
</footer>

<!--<script>
    import '../app.css'

    let { children } = $props();
</script>

<main class="py-8 px-6 min-h-screen flex justify-center">
    {@render children?.()}
</main>

<footer class="bg-primary-300 p-3 w-full flex justify-center">
    <p>Powered by SvelteKit and Open Iconic.</p>
</footer>-->