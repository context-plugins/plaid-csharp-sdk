using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A data scope for the products that a user can consent to in <see href="https://plaid.com/docs/link/data-transparency-messaging-migration-guide">Data Transparency Messaging</see>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ConsentedDataScope>))]
public sealed record ConsentedDataScope : StringEnum<ConsentedDataScope>
{
    private ConsentedDataScope(string value) : base(value)
    {
    }

    public static readonly ConsentedDataScope AccountBalanceInfo = new("account_balance_info");

    public static readonly ConsentedDataScope ContactInfo = new("contact_info");

    public static readonly ConsentedDataScope AccountRoutingNumber = new("account_routing_number");

    public static readonly ConsentedDataScope Transactions = new("transactions");

    public static readonly ConsentedDataScope CreditLoanInfo = new("credit_loan_info");

    public static readonly ConsentedDataScope Investments = new("investments");

    public static readonly ConsentedDataScope PayrollInfo = new("payroll_info");

    public static readonly ConsentedDataScope IncomeVerificationPaystubsInfo = new("income_verification_paystubs_info");

    public static readonly ConsentedDataScope IncomeVerificationW2SInfo = new("income_verification_w2s_info");

    public static readonly ConsentedDataScope IncomeVerificationBankStatements = new("income_verification_bank_statements");

    public static readonly ConsentedDataScope IncomeVerificationEmploymentInfo = new("income_verification_employment_info");

    public static readonly ConsentedDataScope BankStatements = new("bank_statements");

    public static readonly ConsentedDataScope RiskInfo = new("risk_info");

    public static readonly ConsentedDataScope NetworkInsightsLite = new("network_insights_lite");

    public static readonly ConsentedDataScope FraudInfo = new("fraud_info");

    public static ConsentedDataScope FromValue(string value) => FromValueCore(value);
}
