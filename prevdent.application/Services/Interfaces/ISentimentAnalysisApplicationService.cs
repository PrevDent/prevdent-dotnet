using PrevDent.Domain.Entities;

namespace PrevDent.Application.Services.Interfaces
{
    public interface ISentimentAnalysisApplicationService
    {
        SentimentPrediction Predict(string text);
    }
}