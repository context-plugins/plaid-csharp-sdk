using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Valid account subtypes for credit accounts. For a list containing descriptions of each subtype, see <see href="https://plaid.com/docs/api/accounts/#StandaloneAccountType-credit">Account schemas</see>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CreditAccountSubtype>))]
public sealed record CreditAccountSubtype : StringEnum<CreditAccountSubtype>
{
    private CreditAccountSubtype(string value) : base(value)
    {
    }

    public static readonly CreditAccountSubtype CreditCard = new("credit card");

    public static readonly CreditAccountSubtype Paypal = new("paypal");

    public static readonly CreditAccountSubtype All = new("all");

    public static CreditAccountSubtype FromValue(string value) => FromValueCore(value);
}
