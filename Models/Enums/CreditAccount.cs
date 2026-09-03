using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A credit card type account.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CreditAccount>))]
public sealed record CreditAccount : StringEnum<CreditAccount>
{
    private CreditAccount(string value) : base(value)
    {
    }

    public static readonly CreditAccount CreditCard = new("credit card");

    public static readonly CreditAccount Paypal = new("paypal");

    public static CreditAccount FromValue(string value) => FromValueCore(value);
}
