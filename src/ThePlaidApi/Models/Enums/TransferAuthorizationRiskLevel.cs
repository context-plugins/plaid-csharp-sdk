using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Comprises five risk categories (high risk, medium-high risk, medium risk, medium-low risk, low risk) based on the probability of return
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransferAuthorizationRiskLevel>))]
public sealed record TransferAuthorizationRiskLevel : OpenStringEnum<TransferAuthorizationRiskLevel>
{
    private TransferAuthorizationRiskLevel(string value) : base(value)
    {
    }

    public static readonly TransferAuthorizationRiskLevel HighRisk = new("HIGH_RISK");

    public static readonly TransferAuthorizationRiskLevel MediumHighRisk = new("MEDIUM_HIGH_RISK");

    public static readonly TransferAuthorizationRiskLevel MediumRisk = new("MEDIUM_RISK");

    public static readonly TransferAuthorizationRiskLevel MediumLowRisk = new("MEDIUM_LOW_RISK");

    public static readonly TransferAuthorizationRiskLevel LowRisk = new("LOW_RISK");

    public TResult Match<TResult>(Func<TResult> onHighRisk,
        Func<TResult> onMediumHighRisk,
        Func<TResult> onMediumRisk,
        Func<TResult> onMediumLowRisk,
        Func<TResult> onLowRisk,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == HighRisk => onHighRisk(),
            _ when this == MediumHighRisk => onMediumHighRisk(),
            _ when this == MediumRisk => onMediumRisk(),
            _ when this == MediumLowRisk => onMediumLowRisk(),
            _ when this == LowRisk => onLowRisk(),
            _ => otherwise(Value)
        };

    public void Match(Action onHighRisk,
        Action onMediumHighRisk,
        Action onMediumRisk,
        Action onMediumLowRisk,
        Action onLowRisk,
        Action<string> otherwise)
    {
        if (this == HighRisk) onHighRisk();
        else if (this == MediumHighRisk) onMediumHighRisk();
        else if (this == MediumRisk) onMediumRisk();
        else if (this == MediumLowRisk) onMediumLowRisk();
        else if (this == LowRisk) onLowRisk();
        else otherwise(Value);
    }
}
