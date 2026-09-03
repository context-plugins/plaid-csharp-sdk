using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Information about the comparison between the selfie and the document (if documentary verification also ran).
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SelfieAnalysisDocumentComparison>))]
public sealed record SelfieAnalysisDocumentComparison : StringEnum<SelfieAnalysisDocumentComparison>
{
    private SelfieAnalysisDocumentComparison(string value) : base(value)
    {
    }

    public static readonly SelfieAnalysisDocumentComparison Match = new("match");

    public static readonly SelfieAnalysisDocumentComparison NoMatch = new("no_match");

    public static readonly SelfieAnalysisDocumentComparison NoInput = new("no_input");

    public static SelfieAnalysisDocumentComparison FromValue(string value) => FromValueCore(value);
}
