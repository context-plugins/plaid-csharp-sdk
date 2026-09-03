using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The type of Link callback event
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LinkDeliveryWebhookCallbackType>))]
public sealed record LinkDeliveryWebhookCallbackType : StringEnum<LinkDeliveryWebhookCallbackType>
{
    private LinkDeliveryWebhookCallbackType(string value) : base(value)
    {
    }

    public static readonly LinkDeliveryWebhookCallbackType OnSuccess = new("ON_SUCCESS");

    public static readonly LinkDeliveryWebhookCallbackType OnEvent = new("ON_EVENT");

    public static readonly LinkDeliveryWebhookCallbackType OnExit = new("ON_EXIT");

    public static LinkDeliveryWebhookCallbackType FromValue(string value) => FromValueCore(value);
}
