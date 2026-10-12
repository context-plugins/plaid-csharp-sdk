using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Type of a document for risk signal analysis
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RiskSignalDocumentType>))]
public sealed record RiskSignalDocumentType : OpenStringEnum<RiskSignalDocumentType>
{
    private RiskSignalDocumentType(string value) : base(value)
    {
    }

    public static readonly RiskSignalDocumentType Unknown = new("UNKNOWN");

    public static readonly RiskSignalDocumentType BankStatement = new("BANK_STATEMENT");

    public static readonly RiskSignalDocumentType BenefitsStatement = new("BENEFITS_STATEMENT");

    public static readonly RiskSignalDocumentType BusinessFiling = new("BUSINESS_FILING");

    public static readonly RiskSignalDocumentType Check = new("CHECK");

    public static readonly RiskSignalDocumentType DrivingLicense = new("DRIVING_LICENSE");

    public static readonly RiskSignalDocumentType FinancialStatement = new("FINANCIAL_STATEMENT");

    public static readonly RiskSignalDocumentType Invoice = new("INVOICE");

    public static readonly RiskSignalDocumentType Payslip = new("PAYSLIP");

    public static readonly RiskSignalDocumentType SocialSecurityCard = new("SOCIAL_SECURITY_CARD");

    public static readonly RiskSignalDocumentType TaxForm = new("TAX_FORM");

    public static readonly RiskSignalDocumentType UtilityBill = new("UTILITY_BILL");

    public TResult Match<TResult>(Func<TResult> onUnknown,
        Func<TResult> onBankStatement,
        Func<TResult> onBenefitsStatement,
        Func<TResult> onBusinessFiling,
        Func<TResult> onCheck,
        Func<TResult> onDrivingLicense,
        Func<TResult> onFinancialStatement,
        Func<TResult> onInvoice,
        Func<TResult> onPayslip,
        Func<TResult> onSocialSecurityCard,
        Func<TResult> onTaxForm,
        Func<TResult> onUtilityBill,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Unknown => onUnknown(),
            _ when this == BankStatement => onBankStatement(),
            _ when this == BenefitsStatement => onBenefitsStatement(),
            _ when this == BusinessFiling => onBusinessFiling(),
            _ when this == Check => onCheck(),
            _ when this == DrivingLicense => onDrivingLicense(),
            _ when this == FinancialStatement => onFinancialStatement(),
            _ when this == Invoice => onInvoice(),
            _ when this == Payslip => onPayslip(),
            _ when this == SocialSecurityCard => onSocialSecurityCard(),
            _ when this == TaxForm => onTaxForm(),
            _ when this == UtilityBill => onUtilityBill(),
            _ => otherwise(Value)
        };

    public void Match(Action onUnknown,
        Action onBankStatement,
        Action onBenefitsStatement,
        Action onBusinessFiling,
        Action onCheck,
        Action onDrivingLicense,
        Action onFinancialStatement,
        Action onInvoice,
        Action onPayslip,
        Action onSocialSecurityCard,
        Action onTaxForm,
        Action onUtilityBill,
        Action<string> otherwise)
    {
        if (this == Unknown) onUnknown();
        else if (this == BankStatement) onBankStatement();
        else if (this == BenefitsStatement) onBenefitsStatement();
        else if (this == BusinessFiling) onBusinessFiling();
        else if (this == Check) onCheck();
        else if (this == DrivingLicense) onDrivingLicense();
        else if (this == FinancialStatement) onFinancialStatement();
        else if (this == Invoice) onInvoice();
        else if (this == Payslip) onPayslip();
        else if (this == SocialSecurityCard) onSocialSecurityCard();
        else if (this == TaxForm) onTaxForm();
        else if (this == UtilityBill) onUtilityBill();
        else otherwise(Value);
    }
}
