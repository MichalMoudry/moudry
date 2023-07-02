<script>
	import Link from '$lib/components/atoms/link.svelte';
	import ProfileInformation from '$lib/components/organisms/profile_information.svelte';
	import '../app.css';
</script>

<main class="bg-slate-100 h-full p-4">
	<div class="flex justify-center">
		<div class="grid sm:grid-cols-1 sm:grid-rows-2 md:grid-cols-2 md:grid-rows-1 gap-4 sm:w-full md:max-w-3xl">
			<div class="lg:max-w-sm">
				<ProfileInformation />
			</div>

			<div class="lg:max-w-3xl">
				<slot />
			</div>
		</div>
	</div>
</main>

<footer class="bg-primary-300 p-4 w-full flex justify-center">
	<p>Powered by <Link url="https://github.com/iconic/open-iconic" title="Open Iconic" content="Open Iconic" /></p>
</footer>
