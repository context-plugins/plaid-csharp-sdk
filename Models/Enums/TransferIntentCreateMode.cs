using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The direction of the flow of transfer funds.
/// <para>
/// <c>PAYMENT</c>: Transfers funds from an end user's account to your business account.
/// </para>
/// <para>
/// <c>DISBURSEMENT</c>: Transfers funds from your business account to an end user's account.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransferIntentCreateMode>))]
public sealed record TransferIntentCreateMode : StringEnum<TransferIntentCreateMode>
{
    private TransferIntentCreateMode(string value) : base(value)
    {
    }

    public static readonly TransferIntentCreateMode Payment = new("PAYMENT");

    public static readonly TransferIntentCreateMode Disbursement = new("DISBURSEMENT");

    public static TransferIntentCreateMode FromValue(string value) => FromValueCore(value);
}
