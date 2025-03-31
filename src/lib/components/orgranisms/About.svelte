<script>
	import IconHeader from "../molecules/IconHeader.svelte";
</script>

<div class="grid items-center gap-6 sm:grid-cols-4">
    <img src="./profile-image.jpg" alt="Michal Moudrý" class="w-full rounded-2xl" draggable="false" />
    <div class="sm:col-span-3">
        <IconHeader icon="browser" id="about" text="About" />

        <p class="text-justify">
            .NET developer and occasionally a security engineer. Nowadays, working mostly in C# and .NET
            ecosystem developing web services and other types of applications. Currently, I am learning Go,
            C++ and Powershell.
        </p>
    </div>
</div>