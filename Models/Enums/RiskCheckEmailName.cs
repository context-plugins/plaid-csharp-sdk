using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Indicates whether the provided name matches the email address according to the KYC name-matches-email inference result if known.
/// <para>
/// <c>match</c> - "The email's name identifiers match the user's name."
/// </para>
/// <para>
/// <c>partial_match</c> - "The email's name identifiers partially match the user's name."
/// </para>
/// <para>
/// <c>no_match</c> - "The email's name identifiers do not match the user's name."
/// </para>
/// <para>
/// <c>indeterminate</c> - "The email does not contain any name identifiers, and a match could not be determined."
/// </para>
/// <para>
/// <c>no_input</c> - "The user's profile does not contain the required user inputs to determine a match."
/// </para>
/// <para>
/// <c>no_data</c> - "Field could not be verified against available sources."
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RiskCheckEmailName>))]
public sealed record RiskCheckEmailName : StringEnum<RiskCheckEmailName>
{
    private RiskCheckEmailName(string value) : base(value)
    {
    }

    public static readonly RiskCheckEmailName NoInput = new("no_input");

    public static readonly RiskCheckEmailName Indeterminate = new("indeterminate");

    public static readonly RiskCheckEmailName NoMatch = new("no_match");

    public static readonly RiskCheckEmailName PartialMatch = new("partial_match");

    public static readonly RiskCheckEmailName Match = new("match");

    public static readonly RiskCheckEmailName NoData = new("no_data");

    public static RiskCheckEmailName FromValue(string value) => FromValueCore(value);
}
