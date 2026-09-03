using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The communication method used to deliver the Hosted Link session
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LinkDeliveryWebhookCommunicationMethod>))]
public sealed record LinkDeliveryWebhookCommunicationMethod : StringEnum<LinkDeliveryWebhookCommunicationMethod>
{
    private LinkDeliveryWebhookCommunicationMethod(string value) : base(value)
    {
    }

    public static readonly LinkDeliveryWebhookCommunicationMethod Sms = new("SMS");

    public static readonly LinkDeliveryWebhookCommunicationMethod Email = new("EMAIL");

    public static LinkDeliveryWebhookCommunicationMethod FromValue(string value) => FromValueCore(value);
}
