using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Indicates whether the transfer is guaranteed by Plaid (Guarantee customers only). This field will contain either <c>GUARANTEED</c> or <c>NOT_GUARANTEED</c> indicating whether Plaid will guarantee the transfer.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransferAuthorizationGuaranteeDecision>))]
public sealed record TransferAuthorizationGuaranteeDecision : StringEnum<TransferAuthorizationGuaranteeDecision>
{
    private TransferAuthorizationGuaranteeDecision(string value) : base(value)
    {
    }

    public static readonly TransferAuthorizationGuaranteeDecision Guaranteed = new("GUARANTEED");

    public static readonly TransferAuthorizationGuaranteeDecision NotGuaranteed = new("NOT_GUARANTEED");

    public static TransferAuthorizationGuaranteeDecision FromValue(string value) => FromValueCore(value);
}
