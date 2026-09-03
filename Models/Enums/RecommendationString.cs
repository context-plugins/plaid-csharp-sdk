using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The recommendation result for that date.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RecommendationString>))]
public sealed record RecommendationString : StringEnum<RecommendationString>
{
    private RecommendationString(string value) : base(value)
    {
    }

    public static readonly RecommendationString Recommended = new("RECOMMENDED");

    public static readonly RecommendationString NotRecommended = new("NOT_RECOMMENDED");

    public static readonly RecommendationString Unknown = new("UNKNOWN");

    public static RecommendationString FromValue(string value) => FromValueCore(value);
}
