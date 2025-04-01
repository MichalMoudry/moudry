<script>
	let { hasPadding = true, classes = '', children } = $props();
	const padding = hasPadding ? ' p-6' : '';
</script>

<div class="bg-white rounded-md shadow{padding} {classes}">
	{@render children?.()}
</div>
