using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The status type of the student loan
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type2>))]
public sealed record Type2 : StringEnum<Type2>
{
    private Type2(string value) : base(value)
    {
    }

    public static readonly Type2 Cancelled = new("cancelled");

    public static readonly Type2 ChargedOff = new("charged off");

    public static readonly Type2 Claim = new("claim");

    public static readonly Type2 Consolidated = new("consolidated");

    public static readonly Type2 Deferment = new("deferment");

    public static readonly Type2 Delinquent = new("delinquent");

    public static readonly Type2 Discharged = new("discharged");

    public static readonly Type2 Extension = new("extension");

    public static readonly Type2 Forbearance = new("forbearance");

    public static readonly Type2 InGrace = new("in grace");

    public static readonly Type2 InMilitary = new("in military");

    public static readonly Type2 InSchool = new("in school");

    public static readonly Type2 NotFullyDisbursed = new("not fully disbursed");

    public static readonly Type2 Other = new("other");

    public static readonly Type2 PaidInFull = new("paid in full");

    public static readonly Type2 Refunded = new("refunded");

    public static readonly Type2 Repayment = new("repayment");

    public static readonly Type2 Transferred = new("transferred");

    public static readonly Type2 PendingIdr = new("pending idr");

    public static Type2 FromValue(string value) => FromValueCore(value);
}
