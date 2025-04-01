<script>
	/**
	 * @type {{ url: string, title: string, content: string, classes: string }}
	 */
	let { url, title, content, classes = '' } = $props();
</script>

<a href="https://www.{url}" {title} class="text-blue-800 {classes}">{content}</a>
