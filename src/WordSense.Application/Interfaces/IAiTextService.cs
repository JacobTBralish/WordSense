using WordSense.Application.DTOs;

namespace WordSense.Application.Interfaces;

/// <summary>
/// Abstraction for AI text operations. Lets us swap OpanAI/FakeAi without touching the API/Worker.
/// </summary>
public interface IAiTextService
{
    Task<SentimentResponse> SentimentAsync(SentimentRequest request);
    Task<SummarizeRequest> SummerizeAsync(SummarizeRequest request);
    Task<CategorizeRequest> CategorizeAsync(KeywordsRequest request);
    Task<KeywordsResult> KeywordsAsync(KeywordsRequest request);
}