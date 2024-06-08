<script>
  import Card from '$lib/components/atoms/card.svelte'
  import DateRangeDisplay from '$lib/components/atoms/date_range_display.svelte'
  import IconHeader from '$lib/components/molecules/icon_header.svelte'
  import Project from '$lib/components/molecules/project.svelte'
</script>

<Card>
  <IconHeader icon="monitor" text="Vysoká škola ekonomická v Praze" />
  <DateRangeDisplay startDate="2021" endDate="2024" />
  <p>Two and a half year study of information systems and technologies.</p>
</Card>

<Card classes="mt-4">
  <IconHeader icon="briefcase" text="Projects & other work" />

  <Project header="Final thesis">
    <p>Done... description to be added...</p>
  </Project>

  <Project header="Web application in ReactJS">
    <p>
      Making an app for communities where people could report issues within a specific community. We
      used technologies like ReactJS and GraphQL for this app.
    </p>
  </Project>

  <Project header="Software architecture documentation">
    <p>
      This project was about documenting 2 solutions for a specific information system with an
      appropriate documentation structure. Part of this work was to select 2 different architectures
      (we chose SOA and event-driven architecture). For different views on the system we used UML
      diagrams to communicate its structure (components and their modules) and its deployment
      environment. One requirement was use of ADRs for documenting our decisions regarding our
      architectures.
    </p>
  </Project>

  <Project header="Python course source files">
    <p>
      This is a repository with source files for all the assignments for the Python course, I took
      one semester. Assignments include smaller task like int to text converter to larger ones, like
      a complete semestral work.
    </p>
  </Project>
</Card>
