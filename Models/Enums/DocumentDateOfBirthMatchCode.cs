using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A match summary describing the cross comparison between the subject's date of birth, extracted from the document image, and the date of birth they separately provided to the identity verification attempt.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DocumentDateOfBirthMatchCode>))]
public sealed record DocumentDateOfBirthMatchCode : StringEnum<DocumentDateOfBirthMatchCode>
{
    private DocumentDateOfBirthMatchCode(string value) : base(value)
    {
    }

    public static readonly DocumentDateOfBirthMatchCode Match = new("match");

    public static readonly DocumentDateOfBirthMatchCode PartialMatch = new("partial_match");

    public static readonly DocumentDateOfBirthMatchCode NoMatch = new("no_match");

    public static readonly DocumentDateOfBirthMatchCode NoData = new("no_data");

    public static DocumentDateOfBirthMatchCode FromValue(string value) => FromValueCore(value);
}
