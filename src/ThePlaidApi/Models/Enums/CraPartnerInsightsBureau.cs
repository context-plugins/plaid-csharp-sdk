using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The credit bureau that provided the base FICO score.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CraPartnerInsightsBureau>))]
public sealed record CraPartnerInsightsBureau : OpenStringEnum<CraPartnerInsightsBureau>
{
    private CraPartnerInsightsBureau(string value) : base(value)
    {
    }

    public static readonly CraPartnerInsightsBureau Equifax = new("EQUIFAX");

    public static readonly CraPartnerInsightsBureau Experian = new("EXPERIAN");

    public static readonly CraPartnerInsightsBureau Transunion = new("TRANSUNION");

    public TResult Match<TResult>(Func<TResult> onEquifax,
        Func<TResult> onExperian,
        Func<TResult> onTransunion,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Equifax => onEquifax(),
            _ when this == Experian => onExperian(),
            _ when this == Transunion => onTransunion(),
            _ => otherwise(Value)
        };

    public void Match(Action onEquifax, Action onExperian, Action onTransunion, Action<string> otherwise)
    {
        if (this == Equifax) onEquifax();
        else if (this == Experian) onExperian();
        else if (this == Transunion) onTransunion();
        else otherwise(Value);
    }
}
