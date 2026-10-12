using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A match summary describing the cross comparison between the subject's date of birth, extracted from the document image, and the date of birth they separately provided to the identity verification attempt.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DocumentDateOfBirthMatchCode>))]
public sealed record DocumentDateOfBirthMatchCode : OpenStringEnum<DocumentDateOfBirthMatchCode>
{
    private DocumentDateOfBirthMatchCode(string value) : base(value)
    {
    }

    public static readonly DocumentDateOfBirthMatchCode MatchMember = new("match");

    public static readonly DocumentDateOfBirthMatchCode PartialMatch = new("partial_match");

    public static readonly DocumentDateOfBirthMatchCode NoMatch = new("no_match");

    public static readonly DocumentDateOfBirthMatchCode NoData = new("no_data");

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
