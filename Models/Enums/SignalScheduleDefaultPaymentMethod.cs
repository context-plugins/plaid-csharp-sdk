using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The payment method specified in the <c>default_payment_method</c> field directly impacts the timing recommendations provided by the API for submitting the debit entry to your processor or ODFI. If unspecified, defaults to <c>STANDARD_ACH</c>.
/// <para>
/// <c>SAME_DAY_ACH</c>: Same Day ACH (as defined by Nacha). The API assumes the settlement will occur on the same business day if the <c>/signal/schedule</c> request is submitted by 6:00 PM UTC. Note: The actual cutoff time can vary depending on your payment processor or ODFI. Nacha has established three processing windows for Same Day ACH (Eastern Time): 10:30 AM, 2:45 PM, and 4:45 PM.
/// </para>
/// <para>
/// <c>STANDARD_ACH</c>: Standard ACH (as defined by Nacha), typically settled one to three business days after submission.
/// </para>
/// <para>
/// <c>MULTIPLE_PAYMENT_METHODS</c>: Indicates that there is no default debit rail or multiple payment methods are available, and the transaction could use any of them based on customer policy or availability.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SignalScheduleDefaultPaymentMethod>))]
public sealed record SignalScheduleDefaultPaymentMethod : StringEnum<SignalScheduleDefaultPaymentMethod>
{
    private SignalScheduleDefaultPaymentMethod(string value) : base(value)
    {
    }

    public static readonly SignalScheduleDefaultPaymentMethod SameDayAch = new("SAME_DAY_ACH");

    public static readonly SignalScheduleDefaultPaymentMethod StandardAch = new("STANDARD_ACH");

    public static readonly SignalScheduleDefaultPaymentMethod MultiplePaymentMethods = new("MULTIPLE_PAYMENT_METHODS");

    public static SignalScheduleDefaultPaymentMethod FromValue(string value) => FromValueCore(value);
}
