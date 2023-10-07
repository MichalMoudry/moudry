<script>
	import Card from '$lib/components/atoms/card.svelte';
	import IconHeader from '$lib/components/molecules/icon_header.svelte';
</script>

<Card>
	<IconHeader icon="sun" text="Skills" />

	<h3 class="font-bold">Knowledge in the field</h3>
	<table class="table-auto border border-collapse mt-4 w-full">
		<tbody>
			<tr>
				<td class="border p-2">Software development</td>
				<td class="border p-2">Network management</td>
			</tr>
			<tr>
				<td class="border p-2">Programming</td>
				<td class="border p-2">Software QA</td>
			</tr>
			<tr>
				<td class="border p-2">Mobile apps</td>
				<td class="border p-2">Computer networks</td>
			</tr>
			<tr>
				<td class="border p-2" colspan="2">Information Security</td>
			</tr>
		</tbody>
	</table>

	<h3 class="font-bold mt-6">Tools and technologies</h3>
	<table class="table-auto border border-collapse mt-4 w-full">
		<tbody>
			<tr>
				<td class="border p-2">C#</td>
				<td class="border p-2">XAML</td>
			</tr>
			<tr>
				<td class="border p-2">UML</td>
				<td class="border p-2">Python</td>
			</tr>
			<tr>
				<td class="border p-2">Go</td>
				<td class="border p-2">PHP</td>
			</tr>
			<tr>
				<td class="border p-2">LINQ</td>
				<td class="border p-2">JavaScript</td>
			</tr>
			<tr>
				<td class="border p-2">SQL</td>
				<td class="border p-2">Xamarin.Forms</td>
			</tr>
			<tr>
				<td class="border p-2">HTML</td>
				<td class="border p-2">ReactJS</td>
			</tr>
			<tr>
				<td class="border p-2">WPF</td>
				<td class="border p-2">CSS</td>
			</tr>
			<tr>
				<td class="border p-2">UWP</td>
				<td class="border p-2">Bootstrap</td>
			</tr>
			<tr>
				<td class="border p-2">R</td>
				<td class="border p-2">Java</td>
			</tr>
			<tr>
				<td class="border p-2">Microsoft Project</td>
				<td class="border p-2">Power BI</td>
			</tr>
			<tr>
				<td class="border p-2">Microsoft Office</td>
				<td class="border p-2">Microsoft Excel</td>
			</tr>
			<tr>
				<td class="border p-2">Wordpress</td>
				<td class="border p-2">XML</td>
			</tr>
			<tr>
				<td class="border p-2">EF Core</td>
				<td class="border p-2">Linux</td>
			</tr>
			<!--
                <tr>
                    <td class="border p-2">Svelte</td>
                    <td class="border p-2">Tailwind CSS</td>
                </tr>
            -->
		</tbody>
	</table>
</Card>
