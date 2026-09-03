using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// An enum indicating the match type between data provided by user and data checked against an external data source.
/// <para>
///
/// <c>match</c> indicates that the provided input data was a strong match against external data.
/// </para>
/// <para>
/// <c>partial_match</c> indicates the data approximately matched against external data. For example, "Knope" vs. "Knope-Wyatt" for last name.
/// </para>
/// <para>
/// <c>no_match</c> indicates that Plaid was able to perform a check against an external data source and it did not match the provided input data.
/// </para>
/// <para>
/// <c>no_data</c> indicates that Plaid was unable to find external data to compare against the provided input data.
/// </para>
/// <para>
/// <c>no_input</c> indicates that Plaid was unable to perform a check because no information was provided for this field by the end user.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MatchSummaryCode>))]
public sealed record MatchSummaryCode : StringEnum<MatchSummaryCode>
{
    private MatchSummaryCode(string value) : base(value)
    {
    }

    public static readonly MatchSummaryCode Match = new("match");

    public static readonly MatchSummaryCode PartialMatch = new("partial_match");

    public static readonly MatchSummaryCode NoMatch = new("no_match");

    public static readonly MatchSummaryCode NoData = new("no_data");

    public static readonly MatchSummaryCode NoInput = new("no_input");

    public static MatchSummaryCode FromValue(string value) => FromValueCore(value);
}
