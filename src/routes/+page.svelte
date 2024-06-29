<script>
    import About from "$lib/components/organisms/about.svelte"
  import Education from "$lib/components/organisms/education.svelte"
  import NavMenu from "$lib/components/organisms/nav_menu.svelte"
  import WorkExperience from "$lib/components/organisms/work_experience.svelte"
</script>

<div class="flex flex-col">
    <h1 class="text-lg font-bold">Michal Moudrý</h1 >
    <hr class="mb-3 mt-1" />
    <NavMenu/>

    <div class="mt-20">
        <About />
    </div>

    <hr class="my-12" />

    <div>
        <WorkExperience />
    </div>

    <hr class="my-12" />

    <div>
        <Education />
    </div>
</div>