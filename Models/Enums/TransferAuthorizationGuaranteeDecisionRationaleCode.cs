using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A code representing the reason Plaid declined to guarantee this transfer:
/// <para>
/// <c>RETURN_BANK</c>: The risk of a bank-initiated return (for example, an R01/NSF) is too high to guarantee this transfer.
/// </para>
/// <para>
/// <c>RETURN_CUSTOMER</c>: The risk of a customer-initiated return (for example, a R10/Unauthorized) is too high to guarantee this transfer.
/// </para>
/// <para>
/// <c>GUARANTEE_LIMIT_REACHED</c>: This transfer is low-risk, but Guarantee has exhausted an internal limit on the number or rate of guarantees that applies to this transfer.
/// </para>
/// <para>
/// <c>RISK_ESTIMATE_UNAVAILABLE</c>: A risk estimate is unavailable for this Item.
/// </para>
/// <para>
/// <c>REQUIRED_PARAM_MISSING</c>: Required fields are missing.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransferAuthorizationGuaranteeDecisionRationaleCode>))]
public sealed record TransferAuthorizationGuaranteeDecisionRationaleCode : StringEnum<TransferAuthorizationGuaranteeDecisionRationaleCode>
{
    private TransferAuthorizationGuaranteeDecisionRationaleCode(string value) : base(value)
    {
    }

    public static readonly TransferAuthorizationGuaranteeDecisionRationaleCode ReturnBank = new("RETURN_BANK");

    public static readonly TransferAuthorizationGuaranteeDecisionRationaleCode ReturnCustomer = new("RETURN_CUSTOMER");

    public static readonly TransferAuthorizationGuaranteeDecisionRationaleCode GuaranteeLimitReached = new("GUARANTEE_LIMIT_REACHED");

    public static readonly TransferAuthorizationGuaranteeDecisionRationaleCode RiskEstimateUnavailable = new("RISK_ESTIMATE_UNAVAILABLE");

    public static readonly TransferAuthorizationGuaranteeDecisionRationaleCode RequiredParamMissing = new("REQUIRED_PARAM_MISSING");

    public static TransferAuthorizationGuaranteeDecisionRationaleCode FromValue(string value) =>
        FromValueCore(value);
}
