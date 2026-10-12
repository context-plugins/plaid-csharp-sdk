using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A data scope for the products that a user can consent to in <see href="https://plaid.com/docs/link/data-transparency-messaging-migration-guide">Data Transparency Messaging</see>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ConsentedDataScope>))]
public sealed record ConsentedDataScope : OpenStringEnum<ConsentedDataScope>
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

    public static readonly ConsentedDataScope IncomeVerificationBankStatements = new(
        "income_verification_bank_statements");

    public static readonly ConsentedDataScope IncomeVerificationEmploymentInfo = new(
        "income_verification_employment_info");

    public static readonly ConsentedDataScope BankStatements = new("bank_statements");

    public static readonly ConsentedDataScope RiskInfo = new("risk_info");

    public static readonly ConsentedDataScope NetworkInsightsLite = new("network_insights_lite");

    public static readonly ConsentedDataScope FraudInfo = new("fraud_info");

    public TResult Match<TResult>(Func<TResult> onAccountBalanceInfo,
        Func<TResult> onContactInfo,
        Func<TResult> onAccountRoutingNumber,
        Func<TResult> onTransactions,
        Func<TResult> onCreditLoanInfo,
        Func<TResult> onInvestments,
        Func<TResult> onPayrollInfo,
        Func<TResult> onIncomeVerificationPaystubsInfo,
        Func<TResult> onIncomeVerificationW2SInfo,
        Func<TResult> onIncomeVerificationBankStatements,
        Func<TResult> onIncomeVerificationEmploymentInfo,
        Func<TResult> onBankStatements,
        Func<TResult> onRiskInfo,
        Func<TResult> onNetworkInsightsLite,
        Func<TResult> onFraudInfo,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AccountBalanceInfo => onAccountBalanceInfo(),
            _ when this == ContactInfo => onContactInfo(),
            _ when this == AccountRoutingNumber => onAccountRoutingNumber(),
            _ when this == Transactions => onTransactions(),
            _ when this == CreditLoanInfo => onCreditLoanInfo(),
            _ when this == Investments => onInvestments(),
            _ when this == PayrollInfo => onPayrollInfo(),
            _ when this == IncomeVerificationPaystubsInfo => onIncomeVerificationPaystubsInfo(),
            _ when this == IncomeVerificationW2SInfo => onIncomeVerificationW2SInfo(),
            _ when this == IncomeVerificationBankStatements => onIncomeVerificationBankStatements(),
            _ when this == IncomeVerificationEmploymentInfo => onIncomeVerificationEmploymentInfo(),
            _ when this == BankStatements => onBankStatements(),
            _ when this == RiskInfo => onRiskInfo(),
            _ when this == NetworkInsightsLite => onNetworkInsightsLite(),
            _ when this == FraudInfo => onFraudInfo(),
            _ => otherwise(Value)
        };

    public void Match(Action onAccountBalanceInfo,
        Action onContactInfo,
        Action onAccountRoutingNumber,
        Action onTransactions,
        Action onCreditLoanInfo,
        Action onInvestments,
        Action onPayrollInfo,
        Action onIncomeVerificationPaystubsInfo,
        Action onIncomeVerificationW2SInfo,
        Action onIncomeVerificationBankStatements,
        Action onIncomeVerificationEmploymentInfo,
        Action onBankStatements,
        Action onRiskInfo,
        Action onNetworkInsightsLite,
        Action onFraudInfo,
        Action<string> otherwise)
    {
        if (this == AccountBalanceInfo) onAccountBalanceInfo();
        else if (this == ContactInfo) onContactInfo();
        else if (this == AccountRoutingNumber) onAccountRoutingNumber();
        else if (this == Transactions) onTransactions();
        else if (this == CreditLoanInfo) onCreditLoanInfo();
        else if (this == Investments) onInvestments();
        else if (this == PayrollInfo) onPayrollInfo();
        else if (this == IncomeVerificationPaystubsInfo) onIncomeVerificationPaystubsInfo();
        else if (this == IncomeVerificationW2SInfo) onIncomeVerificationW2SInfo();
        else if (this == IncomeVerificationBankStatements) onIncomeVerificationBankStatements();
        else if (this == IncomeVerificationEmploymentInfo) onIncomeVerificationEmploymentInfo();
        else if (this == BankStatements) onBankStatements();
        else if (this == RiskInfo) onRiskInfo();
        else if (this == NetworkInsightsLite) onNetworkInsightsLite();
        else if (this == FraudInfo) onFraudInfo();
        else otherwise(Value);
    }
}
