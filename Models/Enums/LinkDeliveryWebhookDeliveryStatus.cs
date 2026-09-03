using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The status of the delivery of the Hosted Link to the user
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LinkDeliveryWebhookDeliveryStatus>))]
public sealed record LinkDeliveryWebhookDeliveryStatus : StringEnum<LinkDeliveryWebhookDeliveryStatus>
{
    private LinkDeliveryWebhookDeliveryStatus(string value) : base(value)
    {
    }

    public static readonly LinkDeliveryWebhookDeliveryStatus Success = new("SUCCESS");

    public static readonly LinkDeliveryWebhookDeliveryStatus Failure = new("FAILURE");

    public static LinkDeliveryWebhookDeliveryStatus FromValue(string value) => FromValueCore(value);
}
