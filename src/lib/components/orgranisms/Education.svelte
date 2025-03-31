<script>
	import EduItem from "../molecules/EduItem.svelte";
import IconHeader from "../molecules/IconHeader.svelte";
</script>

<IconHeader icon="monitor" id="education" text="Education" />

<EduItem name="Vysoká škola ekonomická v Praze" startDate="2021" endDate="2024" id="vse1" url="vse.cz">
  <p>Two and a half year study of information systems and technologies.</p>
</EduItem>

<EduItem name="Vysoká škola ekonomická v Praze" startDate="2018" endDate="2021" id="vse2" url="vse.cz" classes="mt-6">
  <p>Three-year study of applied informatics.</p>
</EduItem>

<EduItem name="Střední průmyslová škola na Proseku" startDate="2014" endDate="2018" id="sps" url="sps-prosek.cz" classes="mt-6">
  <p>
    Four-year study of information technology and computer science, ended with a graduation exam.
  </p>
</EduItem>