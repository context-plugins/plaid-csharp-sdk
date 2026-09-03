using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Type of a document for risk signal analysis
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RiskSignalDocumentType>))]
public sealed record RiskSignalDocumentType : StringEnum<RiskSignalDocumentType>
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

    public static RiskSignalDocumentType FromValue(string value) => FromValueCore(value);
}
