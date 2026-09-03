using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A match summary describing the cross comparison between the subject's name, extracted from the document image, and the name they separately provided to the identity verification attempt.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DocumentNameMatchCode>))]
public sealed record DocumentNameMatchCode : StringEnum<DocumentNameMatchCode>
{
    private DocumentNameMatchCode(string value) : base(value)
    {
    }

    public static readonly DocumentNameMatchCode Match = new("match");

    public static readonly DocumentNameMatchCode PartialMatch = new("partial_match");

    public static readonly DocumentNameMatchCode NoMatch = new("no_match");

    public static readonly DocumentNameMatchCode NoData = new("no_data");

    public static DocumentNameMatchCode FromValue(string value) => FromValueCore(value);
}
