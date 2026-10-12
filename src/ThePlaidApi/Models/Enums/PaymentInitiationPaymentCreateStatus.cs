using System;
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
public sealed record PaymentInitiationPaymentCreateStatus : OpenStringEnum<PaymentInitiationPaymentCreateStatus>
{
    private PaymentInitiationPaymentCreateStatus(string value) : base(value)
    {
    }

    public static readonly PaymentInitiationPaymentCreateStatus PaymentStatusInputNeeded = new(
        "PAYMENT_STATUS_INPUT_NEEDED");

    public TResult Match<TResult>(Func<TResult> onPaymentStatusInputNeeded, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == PaymentStatusInputNeeded => onPaymentStatusInputNeeded(),
            _ => otherwise(Value)
        };

    public void Match(Action onPaymentStatusInputNeeded, Action<string> otherwise)
    {
        if (this == PaymentStatusInputNeeded) onPaymentStatusInputNeeded();
        else otherwise(Value);
    }
}
