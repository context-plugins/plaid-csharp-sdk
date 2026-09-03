using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The status of the loan.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CraLoanStatus>))]
public sealed record CraLoanStatus : StringEnum<CraLoanStatus>
{
    private CraLoanStatus(string value) : base(value)
    {
    }

    public static readonly CraLoanStatus Approved = new("APPROVED");

    public static readonly CraLoanStatus Declined = new("DECLINED");

    public static readonly CraLoanStatus Booked = new("BOOKED");

    public static readonly CraLoanStatus Current = new("CURRENT");

    public static readonly CraLoanStatus Delinquent = new("DELINQUENT");

    public static readonly CraLoanStatus Default = new("DEFAULT");

    public static readonly CraLoanStatus ChargedOff = new("CHARGED_OFF");

    public static readonly CraLoanStatus Transferred = new("TRANSFERRED");

    public static readonly CraLoanStatus PaidOff = new("PAID_OFF");

    public static readonly CraLoanStatus Other = new("OTHER");

    public static CraLoanStatus FromValue(string value) => FromValueCore(value);
}
