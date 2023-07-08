<script>
    /**
     * @type {String}
     */
    export let icon;

    /**
     * @type {String}
     */
    export let classes = "";

    /**
     * @type {boolean}
     */
    export let isPrimaryTheme = true;

    let theme = isPrimaryTheme ? "text-primary-300" : "";
</script>

<span class="oi {classes} {theme}" data-glyph="{icon}"></span>