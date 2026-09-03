using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The webhook types that can be fired by this test endpoint.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<WebhookType>))]
public sealed record WebhookType : StringEnum<WebhookType>
{
    private WebhookType(string value) : base(value)
    {
    }

    public static readonly WebhookType Auth = new("AUTH");

    public static readonly WebhookType Holdings = new("HOLDINGS");

    public static readonly WebhookType InvestmentsTransactions = new("INVESTMENTS_TRANSACTIONS");

    public static readonly WebhookType Item = new("ITEM");

    public static readonly WebhookType Liabilities = new("LIABILITIES");

    public static readonly WebhookType Transactions = new("TRANSACTIONS");

    public static readonly WebhookType Assets = new("ASSETS");

    public static WebhookType FromValue(string value) => FromValueCore(value);
}
