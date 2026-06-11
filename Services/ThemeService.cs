using Microsoft.JSInterop;

namespace PisitDev.Services;

public class ThemeService
{
    private readonly IJSRuntime _jsRuntime;
    private bool _isDarkMode;
    private Task? _initializeTask;

    public event Action? OnThemeChanged;
    public bool IsDarkMode => _isDarkMode;

    public ThemeService(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }

    public Task InitializeAsync()
    {
        _initializeTask ??= InitializeInternalAsync();
        return _initializeTask;
    }

    private async Task InitializeInternalAsync()
    {
        _isDarkMode = await _jsRuntime.InvokeAsync<bool>("themeManager.isDark");
        NotifyThemeChanged();
    }

    public async Task ToggleThemeAsync()
    {
        _isDarkMode = !_isDarkMode;
        await _jsRuntime.InvokeVoidAsync("themeManager.setDark", _isDarkMode);
        NotifyThemeChanged();
    }

    private void NotifyThemeChanged() => OnThemeChanged?.Invoke();
}
