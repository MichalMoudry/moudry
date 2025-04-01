<script>
    /**
     * @type {{icon: string, classes: string, isPrimaryTheme: boolean}}
     */
    let { icon, classes = '', isPrimaryTheme = true } = $props();

    let theme = isPrimaryTheme ? 'text-primary-300' : '';
</script>

<span class="oi {theme} {classes}" data-glyph={icon}></span>