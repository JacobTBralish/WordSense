namespace WordSense.Application.DTOs;

/// <summary>
/// HTTP request for async keyword extraction.
/// </summary>
public record KeywordsRequest(string Text, int MaxKeywords = 8);

/// <summary>
/// Completed keywords result.
/// </summary>
public record KeywordsResult(string[] Keywords);