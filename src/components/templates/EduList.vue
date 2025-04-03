<script setup>
import Separator from '../atoms/Separator.vue';
import EduListItem from '../organisms/EduListItem.vue';
</script>

<template>
    <div class="edu-list">
        <EduListItem
            name="Prague University of Economics and Business"
            start-date="2021"
            end-date="2024"
            id="vse-2"
            url="vse.cz">
            <p>
                Two and a half year study of information systems and
                technologies with specialization in Development of
                information system.
            </p>
        </EduListItem>

        <Separator/>

        <EduListItem
            name="Prague University of Economics and Business"
            start-date="2018"
            end-date="2021"
            id="vse-1"
            url="vse-cz">
            <p>Three-year study of applied informatics.</p>
        </EduListItem>

        <Separator/>

        <EduListItem
            name="Střední průmyslová škola na Proseku"
            start-date="2014"
            end-date="2018"
            id="sps"
            url="sps-prosek.cz">
            <p>
                Four-year study of information technology and computer science,
                ended with a graduation exam.
            </p>
        </EduListItem>
    </div>
</template>