using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The payment method to complete the transaction after the risk assessment. It may be different from the default payment method.
/// <para>
/// <c>SAME_DAY_ACH</c>: Same Day ACH by Nacha. The debit transaction is processed and settled on the same day.
/// </para>
/// <para>
/// <c>STANDARD_ACH</c>: Standard ACH by Nacha.
/// </para>
/// <para>
/// <c>MULTIPLE_PAYMENT_METHODS</c>: if there is no default debit rail or there are multiple payment methods.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SignalPaymentMethod>))]
public sealed record SignalPaymentMethod : OpenStringEnum<SignalPaymentMethod>
{
    private SignalPaymentMethod(string value) : base(value)
    {
    }

    public static readonly SignalPaymentMethod SameDayAch = new("SAME_DAY_ACH");

    public static readonly SignalPaymentMethod NextDayAch = new("NEXT_DAY_ACH");

    public static readonly SignalPaymentMethod StandardAch = new("STANDARD_ACH");

    public static readonly SignalPaymentMethod MultiplePaymentMethods = new("MULTIPLE_PAYMENT_METHODS");

    public TResult Match<TResult>(Func<TResult> onSameDayAch,
        Func<TResult> onNextDayAch,
        Func<TResult> onStandardAch,
        Func<TResult> onMultiplePaymentMethods,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == SameDayAch => onSameDayAch(),
            _ when this == NextDayAch => onNextDayAch(),
            _ when this == StandardAch => onStandardAch(),
            _ when this == MultiplePaymentMethods => onMultiplePaymentMethods(),
            _ => otherwise(Value)
        };

    public void Match(Action onSameDayAch,
        Action onNextDayAch,
        Action onStandardAch,
        Action onMultiplePaymentMethods,
        Action<string> otherwise)
    {
        if (this == SameDayAch) onSameDayAch();
        else if (this == NextDayAch) onNextDayAch();
        else if (this == StandardAch) onStandardAch();
        else if (this == MultiplePaymentMethods) onMultiplePaymentMethods();
        else otherwise(Value);
    }
}
