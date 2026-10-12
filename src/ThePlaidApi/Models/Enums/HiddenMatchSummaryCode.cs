using System;
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
[JsonConverter(typeof(StringEnumConverter<HiddenMatchSummaryCode>))]
public sealed record HiddenMatchSummaryCode : OpenStringEnum<HiddenMatchSummaryCode>
{
    private HiddenMatchSummaryCode(string value) : base(value)
    {
    }

    public static readonly HiddenMatchSummaryCode MatchMember = new("match");

    public static readonly HiddenMatchSummaryCode PartialMatch = new("partial_match");

    public static readonly HiddenMatchSummaryCode NoMatch = new("no_match");

    public static readonly HiddenMatchSummaryCode NoData = new("no_data");

    public static readonly HiddenMatchSummaryCode NoInput = new("no_input");

    public TResult Match<TResult>(Func<TResult> onMatchMember,
        Func<TResult> onPartialMatch,
        Func<TResult> onNoMatch,
        Func<TResult> onNoData,
        Func<TResult> onNoInput,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == MatchMember => onMatchMember(),
            _ when this == PartialMatch => onPartialMatch(),
            _ when this == NoMatch => onNoMatch(),
            _ when this == NoData => onNoData(),
            _ when this == NoInput => onNoInput(),
            _ => otherwise(Value)
        };

    public void Match(Action onMatchMember,
        Action onPartialMatch,
        Action onNoMatch,
        Action onNoData,
        Action onNoInput,
        Action<string> otherwise)
    {
        if (this == MatchMember) onMatchMember();
        else if (this == PartialMatch) onPartialMatch();
        else if (this == NoMatch) onNoMatch();
        else if (this == NoData) onNoData();
        else if (this == NoInput) onNoInput();
        else otherwise(Value);
    }
}
