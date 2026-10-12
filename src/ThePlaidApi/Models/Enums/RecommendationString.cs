using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The recommendation result for that date.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RecommendationString>))]
public sealed record RecommendationString : OpenStringEnum<RecommendationString>
{
    private RecommendationString(string value) : base(value)
    {
    }

    public static readonly RecommendationString Recommended = new("RECOMMENDED");

    public static readonly RecommendationString NotRecommended = new("NOT_RECOMMENDED");

    public static readonly RecommendationString Unknown = new("UNKNOWN");

    public TResult Match<TResult>(Func<TResult> onRecommended,
        Func<TResult> onNotRecommended,
        Func<TResult> onUnknown,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Recommended => onRecommended(),
            _ when this == NotRecommended => onNotRecommended(),
            _ when this == Unknown => onUnknown(),
            _ => otherwise(Value)
        };

    public void Match(Action onRecommended, Action onNotRecommended, Action onUnknown, Action<string> otherwise)
    {
        if (this == Recommended) onRecommended();
        else if (this == NotRecommended) onNotRecommended();
        else if (this == Unknown) onUnknown();
        else otherwise(Value);
    }
}
