<script>
	import Button from "../atoms/Button.svelte";
	import IconHeader from "../molecules/IconHeader.svelte";
</script>

<IconHeader icon="sun" id="skills" text="Skills" />

<div class="grid grid-rows-1 grid-cols-2">
    <ul>
        <li class="border-b pb-1">C#</li>
        <li class="border-b py-1">UML</li>
        <li class="border-b py-1">PHP</li>
        <li class="border-b py-1">EF Core</li>
        <li class="border-b py-1">ReactJS</li>
        <li class="pt-1">UWP</li>
    </ul>
    <ul class="mb-4">
        <li class="border-b pb-1">Python</li>
        <li class="border-b py-1">Go</li>
        <li class="border-b py-1">HTML</li>
        <li class="border-b py-1">CSS</li>
        <li class="border-b py-1">XAML</li>
        <li class="pt-1">Power BI</li>
    </ul>
</div>
<Button title="See more" content="View more" isFullWidth={true} bgColor="bg-orange-300" />