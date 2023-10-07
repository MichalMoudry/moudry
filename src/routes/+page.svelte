<script>
	import Card from '$lib/components/atoms/card.svelte';
	import EduListItem from '$lib/components/organisms/edu_list_item.svelte';
	import IconHeader from '$lib/components/molecules/icon_header.svelte';
	import WorkExpListItem from '$lib/components/organisms/work_exp_list_item.svelte';
	import OssContributionListItem from '$lib/components/organisms/oss_contribution_list_item.svelte';
	import LinkIconButton from '$lib/components/organisms/link_icon_button.svelte';
</script>

<Card>
	<IconHeader icon="briefcase" text="Work Experience" />
	<WorkExpListItem
		name=".NET Developer"
		employer="CN Group CZ, Czech Republic"
		startDate="Jul 2022"
	/>
	<hr class="my-4" />
	<WorkExpListItem
		name="Technology Support Administrator"
		employer="IBM, Czech Republic"
		startDate="Jun 2020"
		endDate="Aug 2021"
		description="Working with an ECM system and its separate system for document digitalization (Datacap). Part of this work included development of a COM library for integrating Datacap with the ECM system through a SOAP API."
	/>
	<hr class="my-4" />
	<WorkExpListItem
		name="Service Technician/Web developer"
		employer="Zettabyte IT, London"
		startDate="Feb 2017"
		endDate="Feb 2017"
		description="Working in a computer repair shop, where my primary responsibility was to repair computers. Additionally, I contributed to their internal web application, that was written in PHP language."
	/>
</Card>

<Card classes="mt-4">
	<IconHeader icon="monitor" text="Education" />
	<EduListItem
		name="Vysoká škola ekonomická v Praze"
		startDate="2021"
		endDate="2023"
		id="vse2"
		url="vse.cz"
	>
		<p>Two and a half year study of information systems and technologies.</p>
	</EduListItem>
	<hr class="my-4" />
	<EduListItem
		name="Vysoká škola ekonomická v Praze"
		startDate="2018"
		endDate="2021"
		id="vse1"
		url="vse.cz"
	>
		<p>Three-year study of applied informatics.</p>
	</EduListItem>
	<hr class="my-4" />
	<EduListItem
		name="Střední průmyslová škola na Proseku"
		startDate="2014"
		endDate="2018"
		id="sps"
		url="sps-prosek.cz"
	>
		<p>
			Four-year study of information technology and computer science, ended with a graduation exam.
		</p>
	</EduListItem>
</Card>

<Card classes="mt-4">
	<IconHeader icon="sun" text="Skills" />
	<div class="grid grid-rows-1 grid-cols-2">
		<ul>
			<li class="border-b pb-1">C#</li>
			<li class="border-b py-1">XAML</li>
			<li class="border-b py-1">PHP</li>
			<li class="border-b py-1">EF Core</li>
			<li class="border-b py-1">ReactJS</li>
			<li class="pt-1">UWP</li>
		</ul>
		<ul>
			<li class="border-b pb-1">Python</li>
			<li class="border-b py-1">Go</li>
			<li class="border-b py-1">HTML</li>
			<li class="border-b py-1">CSS</li>
			<li class="border-b py-1">UML</li>
			<li class="pt-1">Power BI</li>
		</ul>
	</div>

	<LinkIconButton
		url="./skills"
		icon="chevron-right"
		content="More skills"
		classes="mt-4 w-full"
		title="View skills page"
	/>
</Card>

<Card classes="mt-4">
	<IconHeader icon="lightbulb" text="Open source contributions" />

	<OssContributionListItem
		name="Ambie"
		url="https://github.com/jenius-apps/ambie"
		description="A modern Windows app that plays soothing tones to help you be healthier, happier, and more relaxed."
	/>

	<hr class="my-4" />

	<OssContributionListItem name="Nunit - docs" url="" description="." />
</Card>

<Card classes="mt-4">
	<IconHeader icon="globe" text="Languages" />

	<p class="font-bold">Czech</p>
	<p>Native or bilingual speaker knowledge</p>
	<hr class="my-4" />

	<p class="font-bold">English</p>
	<p>Knowledge enabling professional work</p>
	<hr class="my-4" />

	<p class="font-bold">German</p>
	<p>Basic knowledge</p>
</Card>
