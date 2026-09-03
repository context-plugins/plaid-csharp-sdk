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
/// <para>
/// This field replaces the <c>transaction_type</c> field.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PaymentChannel>))]
public sealed record PaymentChannel : StringEnum<PaymentChannel>
{
    private PaymentChannel(string value) : base(value)
    {
    }

    public static readonly PaymentChannel Online = new("online");

    public static readonly PaymentChannel InStore = new("in store");

    public static readonly PaymentChannel Other = new("other");

    public static PaymentChannel FromValue(string value) => FromValueCore(value);
}
