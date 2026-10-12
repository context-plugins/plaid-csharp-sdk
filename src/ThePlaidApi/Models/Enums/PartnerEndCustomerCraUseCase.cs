using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A CRA use case under a permissible purpose.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PartnerEndCustomerCraUseCase>))]
public sealed record PartnerEndCustomerCraUseCase : OpenStringEnum<PartnerEndCustomerCraUseCase>
{
    private PartnerEndCustomerCraUseCase(string value) : base(value)
    {
    }

    public static readonly PartnerEndCustomerCraUseCase CreditUnderwriting = new("CREDIT_UNDERWRITING");

    public static readonly PartnerEndCustomerCraUseCase TenantScreening = new("TENANT_SCREENING");

    public static readonly PartnerEndCustomerCraUseCase InvestorOrServicerOfCredit = new(
        "INVESTOR_OR_SERVICER_OF_CREDIT");

    public static readonly PartnerEndCustomerCraUseCase Utilities = new("UTILITIES");

    public static readonly PartnerEndCustomerCraUseCase BankAccountOpening = new("BANK_ACCOUNT_OPENING");

    public static readonly PartnerEndCustomerCraUseCase IdentityVerificationFraudPrevention = new(
        "IDENTITY_VERIFICATION_FRAUD_PREVENTION");

    public static readonly PartnerEndCustomerCraUseCase CollectionsDebtRecovery = new("COLLECTIONS_DEBT_RECOVERY");

    public TResult Match<TResult>(Func<TResult> onCreditUnderwriting,
        Func<TResult> onTenantScreening,
        Func<TResult> onInvestorOrServicerOfCredit,
        Func<TResult> onUtilities,
        Func<TResult> onBankAccountOpening,
        Func<TResult> onIdentityVerificationFraudPrevention,
        Func<TResult> onCollectionsDebtRecovery,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == CreditUnderwriting => onCreditUnderwriting(),
            _ when this == TenantScreening => onTenantScreening(),
            _ when this == InvestorOrServicerOfCredit => onInvestorOrServicerOfCredit(),
            _ when this == Utilities => onUtilities(),
            _ when this == BankAccountOpening => onBankAccountOpening(),
            _ when this == IdentityVerificationFraudPrevention => onIdentityVerificationFraudPrevention(),
            _ when this == CollectionsDebtRecovery => onCollectionsDebtRecovery(),
            _ => otherwise(Value)
        };

    public void Match(Action onCreditUnderwriting,
        Action onTenantScreening,
        Action onInvestorOrServicerOfCredit,
        Action onUtilities,
        Action onBankAccountOpening,
        Action onIdentityVerificationFraudPrevention,
        Action onCollectionsDebtRecovery,
        Action<string> otherwise)
    {
        if (this == CreditUnderwriting) onCreditUnderwriting();
        else if (this == TenantScreening) onTenantScreening();
        else if (this == InvestorOrServicerOfCredit) onInvestorOrServicerOfCredit();
        else if (this == Utilities) onUtilities();
        else if (this == BankAccountOpening) onBankAccountOpening();
        else if (this == IdentityVerificationFraudPrevention) onIdentityVerificationFraudPrevention();
        else if (this == CollectionsDebtRecovery) onCollectionsDebtRecovery();
        else otherwise(Value);
    }
}
