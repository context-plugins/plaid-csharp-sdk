using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Comprises five risk categories (high risk, medium-high risk, medium risk, medium-low risk, low risk) based on the probability of return
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransferAuthorizationRiskLevel>))]
public sealed record TransferAuthorizationRiskLevel : StringEnum<TransferAuthorizationRiskLevel>
{
    private TransferAuthorizationRiskLevel(string value) : base(value)
    {
    }

    public static readonly TransferAuthorizationRiskLevel HighRisk = new("HIGH_RISK");

    public static readonly TransferAuthorizationRiskLevel MediumHighRisk = new("MEDIUM_HIGH_RISK");

    public static readonly TransferAuthorizationRiskLevel MediumRisk = new("MEDIUM_RISK");

    public static readonly TransferAuthorizationRiskLevel MediumLowRisk = new("MEDIUM_LOW_RISK");

    public static readonly TransferAuthorizationRiskLevel LowRisk = new("LOW_RISK");

    public static TransferAuthorizationRiskLevel FromValue(string value) => FromValueCore(value);
}
