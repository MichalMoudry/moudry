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

    /**
     * @type {String}
     */
    export let classes = "";

    /**
     * @type {String}
     */
    export let title;
</script>

<a href={url} title="Link to {content}">
    <IconButton icon={icon} content={content} placement={placement} classes={classes} title={title} />
</a>