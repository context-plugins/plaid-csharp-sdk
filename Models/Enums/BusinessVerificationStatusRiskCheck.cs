using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Status of the business risk assessment check
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BusinessVerificationStatusRiskCheck>))]
public sealed record BusinessVerificationStatusRiskCheck : StringEnum<BusinessVerificationStatusRiskCheck>
{
    private BusinessVerificationStatusRiskCheck(string value) : base(value)
    {
    }

    public static readonly BusinessVerificationStatusRiskCheck Active = new("active");

    public static readonly BusinessVerificationStatusRiskCheck Success = new("success");

    public static readonly BusinessVerificationStatusRiskCheck Failed = new("failed");

    public static BusinessVerificationStatusRiskCheck FromValue(string value) => FromValueCore(value);
}
