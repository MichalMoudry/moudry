<script>
    import About from "$lib/components/organisms/about.svelte"
    import Education from "$lib/components/organisms/education.svelte"
    import Languages from "$lib/components/organisms/languages.svelte"
    import NavMenu from "$lib/components/organisms/nav_menu.svelte"
    import Oss from "$lib/components/organisms/oss.svelte"
    import Skills from "$lib/components/organisms/skills.svelte"
    import WorkExperience from "$lib/components/organisms/work_experience.svelte"
</script>

<div class="flex flex-col">
    <h1 class="text-lg font-bold">Michal Moudrý</h1 >
    <hr class="mb-3 mt-1 border-slate-300" />
    <NavMenu/>

    <div class="mt-20">
        <About />
    </div>

    <hr class="my-12 border-dashed border-slate-400" />

    <div>
        <WorkExperience />
    </div>

    <hr class="my-12 border-dashed border-slate-400" />

    <div>
        <Education />
    </div>

    <hr class="my-12 border-dashed border-slate-400" />

    <div>
        <Skills />
    </div>

    <hr class="my-12 border-dashed border-slate-400" />

    <div>
        <Oss />
    </div>

    <hr class="my-12 border-dashed border-slate-400" />

    <div>
        <Languages />
    </div>
</div>