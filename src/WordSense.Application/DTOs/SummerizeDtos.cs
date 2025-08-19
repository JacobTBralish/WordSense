namespace WordSense.Application.DTOs;

/// <summary>
/// HTTP request body for async summarization.
/// </summary>
public record SummarizeRequest(string Test, int MaxSentances = 3);

/// <summary>
/// Final result of the worker computes and we expose via GET /api/jobs/{id}.
/// </summary>
public record SummarizeResult(string Summary);