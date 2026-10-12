using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The type of balance.
/// <para>
/// <c>prefunded_rtp_credits</c> - Your prefunded RTP credit balance with Plaid
/// <c>prefunded_ach_credits</c> - Your prefunded ACH credit balance with Plaid
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransferBalanceType>))]
public sealed record TransferBalanceType : OpenStringEnum<TransferBalanceType>
{
    private TransferBalanceType(string value) : base(value)
    {
    }

    public static readonly TransferBalanceType PrefundedRtpCredits = new("prefunded_rtp_credits");

    public static readonly TransferBalanceType PrefundedAchCredits = new("prefunded_ach_credits");

    public TResult Match<TResult>(Func<TResult> onPrefundedRtpCredits,
        Func<TResult> onPrefundedAchCredits,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == PrefundedRtpCredits => onPrefundedRtpCredits(),
            _ when this == PrefundedAchCredits => onPrefundedAchCredits(),
            _ => otherwise(Value)
        };

    public void Match(Action onPrefundedRtpCredits, Action onPrefundedAchCredits, Action<string> otherwise)
    {
        if (this == PrefundedRtpCredits) onPrefundedRtpCredits();
        else if (this == PrefundedAchCredits) onPrefundedAchCredits();
        else otherwise(Value);
    }
}
