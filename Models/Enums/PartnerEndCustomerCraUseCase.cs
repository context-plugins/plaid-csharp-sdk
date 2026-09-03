using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A CRA use case under a permissible purpose.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PartnerEndCustomerCraUseCase>))]
public sealed record PartnerEndCustomerCraUseCase : StringEnum<PartnerEndCustomerCraUseCase>
{
    private PartnerEndCustomerCraUseCase(string value) : base(value)
    {
    }

    public static readonly PartnerEndCustomerCraUseCase CreditUnderwriting = new("CREDIT_UNDERWRITING");

    public static readonly PartnerEndCustomerCraUseCase TenantScreening = new("TENANT_SCREENING");

    public static readonly PartnerEndCustomerCraUseCase InvestorOrServicerOfCredit = new("INVESTOR_OR_SERVICER_OF_CREDIT");

    public static readonly PartnerEndCustomerCraUseCase Utilities = new("UTILITIES");

    public static readonly PartnerEndCustomerCraUseCase BankAccountOpening = new("BANK_ACCOUNT_OPENING");

    public static readonly PartnerEndCustomerCraUseCase IdentityVerificationFraudPrevention = new("IDENTITY_VERIFICATION_FRAUD_PREVENTION");

    public static readonly PartnerEndCustomerCraUseCase CollectionsDebtRecovery = new("COLLECTIONS_DEBT_RECOVERY");

    public static PartnerEndCustomerCraUseCase FromValue(string value) => FromValueCore(value);
}
