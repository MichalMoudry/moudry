<script>
	import Card from '$lib/components/atoms/Card.svelte';
	import IconHeader from '$lib/components/molecules/IconHeader.svelte';
	import EduList from '$lib/components/templates/EduList.svelte';
	import WorkExpList from '$lib/components/templates/WorkExpList.svelte';
</script>

<Card>
	<IconHeader icon="browser" text="About" />
	<p>
		.NET developer and occasionally a security engineer. Nowadays, working mostly in C# and .NET
		ecosystem developing web services and other types of applications. Currently, I am learning Go,
		C++ and Powershell.
	</p>
</Card>

<Card classes="mt-4">
	<IconHeader icon="briefcase" text="Work Experience" />
	<WorkExpList />
</Card>

<Card classes="mt-4">
	<IconHeader icon="monitor" text="Education" />
	<EduList />
</Card>

<Card classes="mt-4">
	<IconHeader icon="sun" text="Skills" />
</Card>

<Card classes="mt-4">
	<IconHeader icon="lightbulb" text="Open source contributions" />
</Card>

<Card classes="mt-4">
	<IconHeader icon="globe" text="Languages" />
</Card>
