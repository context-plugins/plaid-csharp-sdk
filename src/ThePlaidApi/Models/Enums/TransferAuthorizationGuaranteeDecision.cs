using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Indicates whether the transfer is guaranteed by Plaid (Guarantee customers only). This field will contain either <c>GUARANTEED</c> or <c>NOT_GUARANTEED</c> indicating whether Plaid will guarantee the transfer.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransferAuthorizationGuaranteeDecision>))]
public sealed record TransferAuthorizationGuaranteeDecision : OpenStringEnum<TransferAuthorizationGuaranteeDecision>
{
    private TransferAuthorizationGuaranteeDecision(string value) : base(value)
    {
    }

    public static readonly TransferAuthorizationGuaranteeDecision Guaranteed = new("GUARANTEED");

    public static readonly TransferAuthorizationGuaranteeDecision NotGuaranteed = new("NOT_GUARANTEED");

    public TResult Match<TResult>(Func<TResult> onGuaranteed,
        Func<TResult> onNotGuaranteed,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Guaranteed => onGuaranteed(),
            _ when this == NotGuaranteed => onNotGuaranteed(),
            _ => otherwise(Value)
        };

    public void Match(Action onGuaranteed, Action onNotGuaranteed, Action<string> otherwise)
    {
        if (this == Guaranteed) onGuaranteed();
        else if (this == NotGuaranteed) onNotGuaranteed();
        else otherwise(Value);
    }
}
