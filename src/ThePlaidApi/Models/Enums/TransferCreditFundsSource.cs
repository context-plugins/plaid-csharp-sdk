using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// This field is now deprecated. You may ignore it for transfers created on and after 12/01/2023.
/// <para>
/// Specifies the source of funds for the transfer. Only valid for <c>credit</c> transfers, and defaults to <c>sweep</c> if not specified. This field is not specified for <c>debit</c> transfers.
/// </para>
/// <para>
/// <c>sweep</c> - Sweep funds from your funding account
/// <c>prefunded_rtp_credits</c> - Use your prefunded RTP credit balance with Plaid
/// <c>prefunded_ach_credits</c> - Use your prefunded ACH credit balance with Plaid
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransferCreditFundsSource>))]
public sealed record TransferCreditFundsSource : OpenStringEnum<TransferCreditFundsSource>
{
    private TransferCreditFundsSource(string value) : base(value)
    {
    }

    public static readonly TransferCreditFundsSource Sweep = new("sweep");

    public static readonly TransferCreditFundsSource PrefundedRtpCredits = new("prefunded_rtp_credits");

    public static readonly TransferCreditFundsSource PrefundedAchCredits = new("prefunded_ach_credits");

    public TResult Match<TResult>(Func<TResult> onSweep,
        Func<TResult> onPrefundedRtpCredits,
        Func<TResult> onPrefundedAchCredits,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Sweep => onSweep(),
            _ when this == PrefundedRtpCredits => onPrefundedRtpCredits(),
            _ when this == PrefundedAchCredits => onPrefundedAchCredits(),
            _ => otherwise(Value)
        };

    public void Match(Action onSweep,
        Action onPrefundedRtpCredits,
        Action onPrefundedAchCredits,
        Action<string> otherwise)
    {
        if (this == Sweep) onSweep();
        else if (this == PrefundedRtpCredits) onPrefundedRtpCredits();
        else if (this == PrefundedAchCredits) onPrefundedAchCredits();
        else otherwise(Value);
    }
}
