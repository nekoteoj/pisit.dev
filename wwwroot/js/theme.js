// Immediately apply the theme preference before rendering to prevent FOUC (flash of unstyled content)
(function () {
    const theme = localStorage.getItem('theme');
    if (theme === 'dark' || (!theme && window.matchMedia('(prefers-color-scheme: dark)').matches)) {
        document.documentElement.classList.add('dark');
    } else {
        document.documentElement.classList.remove('dark');
    }
})();

// Helper functions for Blazor JSRuntime
window.themeManager = {
    isDark: function () {
        return document.documentElement.classList.contains('dark');
    },
    setDark: function (isDark) {
        if (isDark) {
            document.documentElement.classList.add('dark');
            localStorage.setItem('theme', 'dark');
        } else {
            document.documentElement.classList.remove('dark');
            localStorage.setItem('theme', 'light');
        }
    }
};
