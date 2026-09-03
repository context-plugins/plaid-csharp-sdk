using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The Plaid environment the webhook was sent from
/// </summary>
[JsonConverter(typeof(StringEnumConverter<WebhookEnvironmentValues>))]
public sealed record WebhookEnvironmentValues : StringEnum<WebhookEnvironmentValues>
{
    private WebhookEnvironmentValues(string value) : base(value)
    {
    }

    public static readonly WebhookEnvironmentValues Sandbox = new("sandbox");

    public static readonly WebhookEnvironmentValues Production = new("production");

    public static WebhookEnvironmentValues FromValue(string value) => FromValueCore(value);
}
