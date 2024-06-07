<script>
	import Link from '$lib/components/atoms/link.svelte';
	import ProfileInformation from '$lib/components/organisms/profile_information.svelte';
	import '../app.css';
</script>

<main class="p-4 min-h-screen flex justify-center">
	<div class="grid container gap-4 grid-cols-1 md:grid-cols-4">
		<div>
			<ProfileInformation />
		</div>

		<div class="w-full col-span-2 sm:col-span-1 md:col-span-3">
			<slot />
		</div>
	</div>
</main>

<footer class="bg-primary-300 p-4 w-full flex justify-center">
	<p>
		Powered by
		<Link url="https://github.com/iconic/open-iconic" title="Open Iconic" content="Open Iconic" /> and
		<Link url="https://kit.svelte.dev" title="SvelteKit" content="SvelteKit" />
	</p>
</footer>
