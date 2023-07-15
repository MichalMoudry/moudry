<script>
    import Card from "../atoms/card.svelte";
    import IconText from "../molecules/icon_text.svelte";
    import Icon from "../atoms/icon.svelte";
    import LargeBoldText from "../atoms/large_bold_text.svelte";
    import Link from "../atoms/link.svelte";
</script>

<Card hasPadding={false}>
    <div class="relative">
        <img src="/profile-image.jpg" alt="Michal Moudrý" draggable="false" class="rounded-t" />
        <h1 class="text-3xl bg-primary-300 bg-opacity-80 bottom-0 ps-4 py-6 absolute w-full">Michal Moudrý</h1>
    </div>

    <div class="p-4">
        <IconText icon="home" text="Czechia" />
        <hr class="my-4" />
        <p>
            <Icon icon="link-intact" classes="me-2 text-xl" />
            <LargeBoldText text="Other links" />
        </p>
        <div class="flex flex-col mt-1">
            <Link url="https://linkedin.com/in/michal-moudry/" title="LinkedIn" content="LinkedIn" classes="p-2 hover:bg-primary-300 rounded mt-2" />
            <Link url="https://twitter.com/MichalMoudry" title="Twitter" content="Twitter" classes="p-2 hover:bg-primary-300 rounded mt-2" />
            <Link url="https://github.com/MichalMoudry" title="GitHub" content="GitHub" classes="p-2 hover:bg-primary-300 rounded mt-2" />
            <Link url="https://stackoverflow.com/users/8302741/michal-moudr%C3%BD?tab=profile" title="GitLab" content="GitLab" classes="p-2 hover:bg-primary-300 rounded mt-2" />
        </div>
    </div>
</Card>