<script>
	import Icon from "../atoms/icon.svelte";

    /**
     * @type {String}
     */
    export let icon;

    /**
     * @type {String}
     */
    export let text;
</script>

<h2 class="flex items-center mb-4">
    <Icon icon={icon} classes="me-4 text-3xl" />
    <span class="text-2xl">{text}</span>
</h2>