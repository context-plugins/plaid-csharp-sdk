using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The decision of the loan application.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CraLoanApplicationDecision>))]
public sealed record CraLoanApplicationDecision : StringEnum<CraLoanApplicationDecision>
{
    private CraLoanApplicationDecision(string value) : base(value)
    {
    }

    public static readonly CraLoanApplicationDecision Approved = new("APPROVED");

    public static readonly CraLoanApplicationDecision Declined = new("DECLINED");

    public static readonly CraLoanApplicationDecision Other = new("OTHER");

    public static CraLoanApplicationDecision FromValue(string value) => FromValueCore(value);
}
