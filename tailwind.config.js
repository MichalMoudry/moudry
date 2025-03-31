import colors from "tailwindcss/colors";

export default {
    content: ['./src/**/*.{html,js,svelte,ts}'],
    theme: {
        extend: {
            colors: {
                primary: colors.green
            }
        }
    },
    plugins: []
};