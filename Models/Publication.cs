namespace PisitDev.Models;

public record Publication(
    string Title,
    string[] Authors,
    int Year,
    string Venue,
    string? PaperUrl = null,
    string? CodeUrl = null,
    bool IsConference = false);
