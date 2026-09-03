using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The ISO-4217 currency code of the payment. For standing orders and payment consents, <c>"GBP"</c> must be used. For Poland, Denmark, Sweden and Norway, only the local currency is currently supported.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PaymentAmountCurrency>))]
public sealed record PaymentAmountCurrency : StringEnum<PaymentAmountCurrency>
{
    private PaymentAmountCurrency(string value) : base(value)
    {
    }

    public static readonly PaymentAmountCurrency Gbp = new("GBP");

    public static readonly PaymentAmountCurrency Eur = new("EUR");

    public static readonly PaymentAmountCurrency Pln = new("PLN");

    public static readonly PaymentAmountCurrency Sek = new("SEK");

    public static readonly PaymentAmountCurrency Dkk = new("DKK");

    public static readonly PaymentAmountCurrency Nok = new("NOK");

    public static PaymentAmountCurrency FromValue(string value) => FromValueCore(value);
}
