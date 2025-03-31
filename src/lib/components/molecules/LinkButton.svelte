<script>
    import Button from "../atoms/Button.svelte";

    /** @type {{content: string, url: string, title: string}} */
    let { content, url, title } = $props();
</script>

<a href={url} title="Link to {content}">
    <Button {content} {title} />
</a>