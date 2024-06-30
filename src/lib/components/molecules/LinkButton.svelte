<script>
    import Button from "../atoms/button.svelte"

        /**
     * @type {String}
     */
    export let content

    /**
     * @type {String}
     */
    export let url

    /**
     * @type {String}
     */
    export let title
</script>
<a href={url} title="Link to {content}">
    <Button {content} {title} />
</a>