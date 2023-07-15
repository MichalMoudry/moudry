<script>
    /**
     * @type {String}
     */
    export let url;

    /**
     * @type {String}
     */
    export let title;

    /**
     * @type {String}
     */
    export let content;

    /**
     * @type {String}
     */
    export let classes = "";
</script>

<a href={url} title={title} class="hover:underline text-blue-800 {classes}">{content}</a>