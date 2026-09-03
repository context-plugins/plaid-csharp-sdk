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
public sealed record CounterpartyType : StringEnum<CounterpartyType>
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

    public static CounterpartyType FromValue(string value) => FromValueCore(value);
}
