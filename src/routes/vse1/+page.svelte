<script>
    import Card from "$lib/components/atoms/card.svelte"
    import DateRangeDisplay from "$lib/components/atoms/date_range_display.svelte"
    import IconHeader from "$lib/components/molecules/icon_header.svelte"
    import Project from "$lib/components/molecules/project.svelte"
</script>

<Card>
    <IconHeader icon="monitor" text="Vysoká škola ekonomická v Praze" />
    <DateRangeDisplay startDate="2018" endDate="2021" />
    <p>Three-year study of applied informatics.</p>
</Card>

<Card classes="mt-4">
    <IconHeader icon="briefcase" text="Projects & other work" />

    <Project header="Final thesis" isFirst={true}>
        <p>Goal of this bachelor thesis is to create a software solution for
           supporting digitalization process inside an organization which allows
           usage of components for content processing, obtaining data and then
           store those result to database or send them to a different part of
           information system inside the organization.</p>
        <p class="mt-2">This thesis contains current state of a company for which the software
            solution will be made, also in the same chapter there are all request
            specified by the client for said solution. Also, literature review of
            digitalization process and Service Oriented Architecture was carried out,
            furthermore evaluation of similar software solutions was also carried out.
            Next chapter is about technologies used during or for this project. After
            that is a technical documentation, where structure of the solution, database,
            authorization and authentication inside the application is described.</p>
        <p class="mt-2">Practical part of this work was made for people familiar with ASP.NET Core
           and web technologies, when for example client application is using relatively
           new technology inside the world of web apps. Written part is useful for those,
           who want to be more familiar with content digitalization, components involved
           in this process or SOA.</p>
    </Project>

    <Project header="A JS web application">
        <p>A simple web app for writing emails.</p>
        <p><b>Functionality</b>:</p>
        <ul>
            <li>Creating accounts</li>
            <li>Creating scheduled emails</li>
            <li>Saving emails to drafts</li>
            <li>Sending emails</li>
        </ul>
        <p><b>Used libraries</b>:</p>
        <ul>
            <li>Bootstrap</li>
            <li>jQuery</li>
        </ul>
    </Project>

    <Project header="ICT semestral work">
        <p>
            Goal of this work is to describe network file systems, their protocols
            (like <abbr title="Server Message Block">SMB</abbr> and
            <abbr title="Network File System">NFS</abbr>) and their practical applications.
            Part of this work is also dedicated to classic file systems in operating systems.
        </p>
        <p class="mt-2">
            Practical part of this work is about analyzing network traffic between NFS server
            and NFS client for which I have used virtual networks in Microsoft Azure and tool
            called Tshark (a console version of Wireshark).
        </p>
    </Project>

    <Project header="Excel semestral work">
        <p>
            Goal of this project was to create an excel spreadsheet, that contains
            a list of products for video games store. This spreadsheet contains list
            for adding new data to products list, then list with products data (with
            controls for filtering) and subsequent list contains contingency tables.
        </p>
    </Project>

    <Project header="PowerBI for a electronics business">
        <p>
            Creating an app in PowerBI for a company that operates in electronics
            business. App is aimed to help in receivables management.
        </p>
    </Project>

    <Project header="Evaluation of the IBM Datacap system">
        <p>
            Goal of this work was to evaluate IBM Datacap in digitalization process,
            which means evaluating its ability to cover all basic and uncommon
            scenarios that can happen during digitalization process. Goal was achieved
            through studying of available electronic resources (about Datacap and its
            components), also gathering information from a specific implementation of
            an Datacap solution.
        </p>
    </Project>

    <Project header="Website for a czech company">
        <p>
            The goal of this project was to create a website for a company. One
            requirement was to use Wordpress.
        </p>
    </Project>
</Card>