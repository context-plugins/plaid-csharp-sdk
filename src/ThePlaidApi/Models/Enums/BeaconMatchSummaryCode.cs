using System;
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
public sealed record BeaconMatchSummaryCode : OpenStringEnum<BeaconMatchSummaryCode>
{
    private BeaconMatchSummaryCode(string value) : base(value)
    {
    }

    public static readonly BeaconMatchSummaryCode MatchMember = new("match");

    public static readonly BeaconMatchSummaryCode PartialMatch = new("partial_match");

    public static readonly BeaconMatchSummaryCode NoMatch = new("no_match");

    public static readonly BeaconMatchSummaryCode NoData = new("no_data");

    public TResult Match<TResult>(Func<TResult> onMatchMember,
        Func<TResult> onPartialMatch,
        Func<TResult> onNoMatch,
        Func<TResult> onNoData,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == MatchMember => onMatchMember(),
            _ when this == PartialMatch => onPartialMatch(),
            _ when this == NoMatch => onNoMatch(),
            _ when this == NoData => onNoData(),
            _ => otherwise(Value)
        };

    public void Match(Action onMatchMember,
        Action onPartialMatch,
        Action onNoMatch,
        Action onNoData,
        Action<string> otherwise)
    {
        if (this == MatchMember) onMatchMember();
        else if (this == PartialMatch) onPartialMatch();
        else if (this == NoMatch) onNoMatch();
        else if (this == NoData) onNoData();
        else otherwise(Value);
    }
}
