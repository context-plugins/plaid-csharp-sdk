using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The frequency of a loan's payment schedule.
/// <c>BIWEEKLY</c> represents one payment every two weeks.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CraLoanPaymentSchedule>))]
public sealed record CraLoanPaymentSchedule : StringEnum<CraLoanPaymentSchedule>
{
    private CraLoanPaymentSchedule(string value) : base(value)
    {
    }

    public static readonly CraLoanPaymentSchedule Daily = new("DAILY");

    public static readonly CraLoanPaymentSchedule Weekly = new("WEEKLY");

    public static readonly CraLoanPaymentSchedule Biweekly = new("BIWEEKLY");

    public static readonly CraLoanPaymentSchedule Monthly = new("MONTHLY");

    public static readonly CraLoanPaymentSchedule Quarterly = new("QUARTERLY");

    public static readonly CraLoanPaymentSchedule Annually = new("ANNUALLY");

    public static readonly CraLoanPaymentSchedule Other = new("OTHER");

    public static CraLoanPaymentSchedule FromValue(string value) => FromValueCore(value);
}
