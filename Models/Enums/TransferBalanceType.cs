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
public sealed record TransferBalanceType : StringEnum<TransferBalanceType>
{
    private TransferBalanceType(string value) : base(value)
    {
    }

    public static readonly TransferBalanceType PrefundedRtpCredits = new("prefunded_rtp_credits");

    public static readonly TransferBalanceType PrefundedAchCredits = new("prefunded_ach_credits");

    public static TransferBalanceType FromValue(string value) => FromValueCore(value);
}
