using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// An enum indicating the match type between two Beacon Users.
/// <para>
///
/// <c>match</c> indicates that the provided input data was a strong match against the other Beacon User.
/// </para>
/// <para>
/// <c>partial_match</c> indicates the data approximately matched the other Beacon User. For example, "Knope" vs. "Knope-Wyatt" for last name.
/// </para>
/// <para>
/// <c>no_match</c> indicates that Plaid was able to compare this field against the other Beacon User and it did not match the provided input data.
/// </para>
/// <para>
/// <c>no_data</c> indicates that Plaid was unable to compare this field against the original Beacon User because the field was not present in one of the Beacon Users.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BeaconMatchSummaryCode>))]
public sealed record BeaconMatchSummaryCode : StringEnum<BeaconMatchSummaryCode>
{
    private BeaconMatchSummaryCode(string value) : base(value)
    {
    }

    public static readonly BeaconMatchSummaryCode Match = new("match");

    public static readonly BeaconMatchSummaryCode PartialMatch = new("partial_match");

    public static readonly BeaconMatchSummaryCode NoMatch = new("no_match");

    public static readonly BeaconMatchSummaryCode NoData = new("no_data");

    public static BeaconMatchSummaryCode FromValue(string value) => FromValueCore(value);
}
