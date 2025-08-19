namespace  WordSense.Application.DTOs;

/// <summary>
/// Request body for synchronous HTTP sentiment analysis.
/// </summary>
/// <param name="Text">User-provided text to analyze.</param>
public record SentimentRequest(string Text);

/// <summary>
/// Response body for sentiment analysis. A simple "contract" returned by the API.
/// </summary>
/// <param name="Sentiment">"Positive" | "Neutral" | "Negative"</param>
/// <param name="Confidence">Confidence in [0..1].</param>
public record SentimentResponse(string Sentiment, double Confidence);