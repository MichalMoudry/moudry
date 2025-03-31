<script>
	import Icon from "../atoms/Icon.svelte";

    /** @type {{icon: string, text:string, id: string}} */
    let { icon, text, id } = $props();
</script>

<h2 id={id} class="flex items-center mb-3 font-bold">
    <Icon {icon} isPrimaryTheme={false} classes="me-4 text-3xl" />
    <span>{text}</span>
</h2>