using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// High level summary of whether the document in the provided image matches the formatting rules and security checks for the associated jurisdiction.
/// <para>
/// For example, most identity documents have formatting rules like the following:
/// </para>
/// <para>
///
/// The image of the person's face must have a certain contrast in order to highlight skin tone
/// </para>
/// <para>
///
/// The subject in the document's image must remove eye glasses and pose in a certain way
/// </para>
/// <para>
///
/// The informational fields (name, date of birth, ID number, etc.) must be colored and aligned according to specific rules
/// </para>
/// <para>
///
/// Security features like watermarks and background patterns must be present
/// </para>
/// <para>
/// So a <c>match</c> status for this field indicates that the document in the provided image seems to conform to the various formatting and security rules associated with the detected document.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DocumentAuthenticityMatchCode>))]
public sealed record DocumentAuthenticityMatchCode : OpenStringEnum<DocumentAuthenticityMatchCode>
{
    private DocumentAuthenticityMatchCode(string value) : base(value)
    {
    }

    public static readonly DocumentAuthenticityMatchCode MatchMember = new("match");

    public static readonly DocumentAuthenticityMatchCode PartialMatch = new("partial_match");

    public static readonly DocumentAuthenticityMatchCode NoMatch = new("no_match");

    public static readonly DocumentAuthenticityMatchCode NoData = new("no_data");

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
