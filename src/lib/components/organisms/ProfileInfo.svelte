<script>
	import Card from '../atoms/Card.svelte';
	import Link from '../atoms/Link.svelte';
	import IconText from '../molecules/IconText.svelte';
</script>

<Card hasPadding={false}>
	<div class="relative">
		<img src="/profile-image.jpg" alt="Michal Moudrý" draggable="false" class="rounded-t" />
		<h1 class="text-2xl bg-primary-300 bg-opacity-80 bottom-0 ps-4 py-6 absolute w-full">
			Michal Moudrý
		</h1>
	</div>

	<div class="p-4">
		<IconText icon="home" text="Czechia" />
		<div class="flex flex-col mt-1">
			<Link
				url="linkedin.com/in/michal-moudry/"
				title="LinkedIn"
				content="LinkedIn"
				classes="p-2 hover:bg-primary-300 rounded mt-2"
			/>
			<Link
				url="github.com/MichalMoudry"
				title="GitHub"
				content="GitHub"
				classes="p-2 hover:bg-primary-300 rounded mt-2"
			/>
		</div>
	</div>
</Card>
