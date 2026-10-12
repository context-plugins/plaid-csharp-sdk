using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The counterparty type.
/// <para>
/// <c>merchant</c>: a provider of goods or services for purchase
/// <c>financial_institution</c>: a financial entity (bank, credit union, BNPL, fintech)
/// <c>payment_app</c>: a transfer or P2P app (e.g. Zelle)
/// <c>marketplace</c>: a marketplace (e.g. DoorDash, Google Play Store)
/// <c>payment_terminal</c>: a point-of-sale payment terminal (e.g. Square, Toast)
/// <c>income_source</c>: the payer in an income transaction (e.g., an employer, client, or government agency)
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CounterpartyType>))]
public sealed record CounterpartyType : OpenStringEnum<CounterpartyType>
{
    private CounterpartyType(string value) : base(value)
    {
    }

    public static readonly CounterpartyType Merchant = new("merchant");

    public static readonly CounterpartyType FinancialInstitution = new("financial_institution");

    public static readonly CounterpartyType PaymentApp = new("payment_app");

    public static readonly CounterpartyType Marketplace = new("marketplace");

    public static readonly CounterpartyType PaymentTerminal = new("payment_terminal");

    public static readonly CounterpartyType IncomeSource = new("income_source");

    public TResult Match<TResult>(Func<TResult> onMerchant,
        Func<TResult> onFinancialInstitution,
        Func<TResult> onPaymentApp,
        Func<TResult> onMarketplace,
        Func<TResult> onPaymentTerminal,
        Func<TResult> onIncomeSource,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Merchant => onMerchant(),
            _ when this == FinancialInstitution => onFinancialInstitution(),
            _ when this == PaymentApp => onPaymentApp(),
            _ when this == Marketplace => onMarketplace(),
            _ when this == PaymentTerminal => onPaymentTerminal(),
            _ when this == IncomeSource => onIncomeSource(),
            _ => otherwise(Value)
        };

    public void Match(Action onMerchant,
        Action onFinancialInstitution,
        Action onPaymentApp,
        Action onMarketplace,
        Action onPaymentTerminal,
        Action onIncomeSource,
        Action<string> otherwise)
    {
        if (this == Merchant) onMerchant();
        else if (this == FinancialInstitution) onFinancialInstitution();
        else if (this == PaymentApp) onPaymentApp();
        else if (this == Marketplace) onMarketplace();
        else if (this == PaymentTerminal) onPaymentTerminal();
        else if (this == IncomeSource) onIncomeSource();
        else otherwise(Value);
    }
}
