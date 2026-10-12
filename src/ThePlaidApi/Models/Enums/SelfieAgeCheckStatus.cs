using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// An enum indicating whether the reported age aligns with the estimated selfie capture age range.
/// <para>
/// <c>match</c> indicates that the reported age falls within the estimated selfie capture age range.
/// </para>
/// <para>
/// <c>warning</c> indicates that the reported age falls outside the estimated selfie capture age range, but is close enough that the result should be reviewed.
/// </para>
/// <para>
/// <c>no_match</c> indicates that the reported age falls far outside the estimated selfie capture age range.
/// </para>
/// <para>
/// <c>no_data</c> indicates that there was not enough data available at age-estimation time to compare the reported age against the estimated selfie capture age range.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SelfieAgeCheckStatus>))]
public sealed record SelfieAgeCheckStatus : OpenStringEnum<SelfieAgeCheckStatus>
{
    private SelfieAgeCheckStatus(string value) : base(value)
    {
    }

    public static readonly SelfieAgeCheckStatus MatchMember = new("match");

    public static readonly SelfieAgeCheckStatus Warning = new("warning");

    public static readonly SelfieAgeCheckStatus NoMatch = new("no_match");

    public static readonly SelfieAgeCheckStatus NoData = new("no_data");

    public TResult Match<TResult>(Func<TResult> onMatchMember,
        Func<TResult> onWarning,
        Func<TResult> onNoMatch,
        Func<TResult> onNoData,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == MatchMember => onMatchMember(),
            _ when this == Warning => onWarning(),
            _ when this == NoMatch => onNoMatch(),
            _ when this == NoData => onNoData(),
            _ => otherwise(Value)
        };

    public void Match(Action onMatchMember,
        Action onWarning,
        Action onNoMatch,
        Action onNoData,
        Action<string> otherwise)
    {
        if (this == MatchMember) onMatchMember();
        else if (this == Warning) onWarning();
        else if (this == NoMatch) onNoMatch();
        else if (this == NoData) onNoData();
        else otherwise(Value);
    }
}
