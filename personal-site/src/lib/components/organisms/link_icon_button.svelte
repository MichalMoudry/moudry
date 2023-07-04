<script>
	import IconButton from "../molecules/icon_button.svelte";

    /**
     * @type {String}
     */
     export let content;

    /**
     * @type {number}
     */
    export let placement = 1;

    /**
     * @type {String}
     */
    export let icon;

    /**
     * @type {String}
     */
    export let url;
</script>

<a href={url} class="w-full">
    <IconButton icon={icon} content={content} placement={placement} />
</a>