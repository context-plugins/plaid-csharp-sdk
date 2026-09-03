using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The channel used to make a payment.
/// <c>online:</c> transactions that took place online.
/// <para>
/// <c>in store:</c> transactions that were made at a physical location.
/// </para>
/// <para>
/// <c>other:</c> transactions that relate to banks, e.g. fees or deposits.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransactionPaymentChannel>))]
public sealed record TransactionPaymentChannel : StringEnum<TransactionPaymentChannel>
{
    private TransactionPaymentChannel(string value) : base(value)
    {
    }

    public static readonly TransactionPaymentChannel Online = new("online");

    public static readonly TransactionPaymentChannel InStore = new("in store");

    public static readonly TransactionPaymentChannel Other = new("other");

    public static TransactionPaymentChannel FromValue(string value) => FromValueCore(value);
}
