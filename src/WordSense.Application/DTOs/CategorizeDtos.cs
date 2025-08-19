namespace WordSense.Application.DTOs;

/// <summary>
/// HTTP request for async categorization.
/// </summary>
/// <param name="Text">Text to categorize.</param>
/// <param name=CategorySet">
/// Optional target label set to constrain the model (e.g., ["Tech, Finance, Health"]).
/// If null/empty, the model infers categories.
/// </param>
public record CategorizeRequest(string Text, string[]? CategorySet = null);