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
public sealed record SignalPaymentMethod : StringEnum<SignalPaymentMethod>
{
    private SignalPaymentMethod(string value) : base(value)
    {
    }

    public static readonly SignalPaymentMethod SameDayAch = new("SAME_DAY_ACH");

    public static readonly SignalPaymentMethod NextDayAch = new("NEXT_DAY_ACH");

    public static readonly SignalPaymentMethod StandardAch = new("STANDARD_ACH");

    public static readonly SignalPaymentMethod MultiplePaymentMethods = new("MULTIPLE_PAYMENT_METHODS");

    public static SignalPaymentMethod FromValue(string value) => FromValueCore(value);
}
