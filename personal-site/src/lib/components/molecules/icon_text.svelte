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

<p>
    <Icon icon={icon} classes="me-2 text-xl" />
    {text}
</p>