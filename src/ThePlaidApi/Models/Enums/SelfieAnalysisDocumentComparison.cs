using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Information about the comparison between the selfie and the document (if documentary verification also ran).
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SelfieAnalysisDocumentComparison>))]
public sealed record SelfieAnalysisDocumentComparison : OpenStringEnum<SelfieAnalysisDocumentComparison>
{
    private SelfieAnalysisDocumentComparison(string value) : base(value)
    {
    }

    public static readonly SelfieAnalysisDocumentComparison MatchMember = new("match");

    public static readonly SelfieAnalysisDocumentComparison NoMatch = new("no_match");

    public static readonly SelfieAnalysisDocumentComparison NoInput = new("no_input");

    public TResult Match<TResult>(Func<TResult> onMatchMember,
        Func<TResult> onNoMatch,
        Func<TResult> onNoInput,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == MatchMember => onMatchMember(),
            _ when this == NoMatch => onNoMatch(),
            _ when this == NoInput => onNoInput(),
            _ => otherwise(Value)
        };

    public void Match(Action onMatchMember, Action onNoMatch, Action onNoInput, Action<string> otherwise)
    {
        if (this == MatchMember) onMatchMember();
        else if (this == NoMatch) onNoMatch();
        else if (this == NoInput) onNoInput();
        else otherwise(Value);
    }
}
