using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The outcome of checking the associated hit against state databases.
/// <para>
///
/// <c>match</c> - The field is an exact match with the state database.
/// </para>
/// <para>
/// <c>partial_match</c> - The field is a partial match with the state database.
/// </para>
/// <para>
/// <c>no_match</c> - The field is not an exact match with the state database.
/// </para>
/// <para>
/// <c>no_data</c> - The field was unable to be checked against state databases.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AamvaDetailedMatchResult>))]
public sealed record AamvaDetailedMatchResult : OpenStringEnum<AamvaDetailedMatchResult>
{
    private AamvaDetailedMatchResult(string value) : base(value)
    {
    }

    public static readonly AamvaDetailedMatchResult MatchMember = new("match");

    public static readonly AamvaDetailedMatchResult PartialMatch = new("partial_match");

    public static readonly AamvaDetailedMatchResult NoMatch = new("no_match");

    public static readonly AamvaDetailedMatchResult NoData = new("no_data");

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
