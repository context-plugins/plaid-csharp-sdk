using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// For a payment returned by this endpoint, there is only one possible value:
/// <para>
/// <c>PAYMENT_STATUS_INPUT_NEEDED</c>: The initial phase of the payment
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PaymentInitiationPaymentCreateStatus>))]
public sealed record PaymentInitiationPaymentCreateStatus : StringEnum<PaymentInitiationPaymentCreateStatus>
{
    private PaymentInitiationPaymentCreateStatus(string value) : base(value)
    {
    }

    public static readonly PaymentInitiationPaymentCreateStatus PaymentStatusInputNeeded = new("PAYMENT_STATUS_INPUT_NEEDED");

    public static PaymentInitiationPaymentCreateStatus FromValue(string value) => FromValueCore(value);
}
