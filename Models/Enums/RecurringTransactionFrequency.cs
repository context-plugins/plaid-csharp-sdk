using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Describes the frequency of the transaction stream.
/// <para>
/// <c>WEEKLY</c>: Assigned to a transaction stream that occurs approximately every week.
/// </para>
/// <para>
/// <c>BIWEEKLY</c>: Assigned to a transaction stream that occurs approximately every 2 weeks.
/// </para>
/// <para>
/// <c>SEMI_MONTHLY</c>: Assigned to a transaction stream that occurs approximately twice per month. This frequency is typically seen for inflow transaction streams.
/// </para>
/// <para>
/// <c>MONTHLY</c>: Assigned to a transaction stream that occurs approximately every month.
/// </para>
/// <para>
/// <c>ANNUALLY</c>: Assigned to a transaction stream that occurs approximately every year.
/// </para>
/// <para>
/// <c>UNKNOWN</c>: Assigned to a transaction stream that does not fit any of the pre-defined frequencies.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RecurringTransactionFrequency>))]
public sealed record RecurringTransactionFrequency : StringEnum<RecurringTransactionFrequency>
{
    private RecurringTransactionFrequency(string value) : base(value)
    {
    }

    public static readonly RecurringTransactionFrequency Unknown = new("UNKNOWN");

    public static readonly RecurringTransactionFrequency Weekly = new("WEEKLY");

    public static readonly RecurringTransactionFrequency Biweekly = new("BIWEEKLY");

    public static readonly RecurringTransactionFrequency SemiMonthly = new("SEMI_MONTHLY");

    public static readonly RecurringTransactionFrequency Monthly = new("MONTHLY");

    public static readonly RecurringTransactionFrequency Annually = new("ANNUALLY");

    public static RecurringTransactionFrequency FromValue(string value) => FromValueCore(value);
}
