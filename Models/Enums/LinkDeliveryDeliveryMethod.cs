using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The delivery method to be used to deliver the Hosted Link session URL.
/// <para>
/// <c>SMS</c>: The URL will be delivered through SMS
/// </para>
/// <para>
/// <c>EMAIL</c>: The URL will be delivered through email
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LinkDeliveryDeliveryMethod>))]
public sealed record LinkDeliveryDeliveryMethod : StringEnum<LinkDeliveryDeliveryMethod>
{
    private LinkDeliveryDeliveryMethod(string value) : base(value)
    {
    }

    public static readonly LinkDeliveryDeliveryMethod Sms = new("SMS");

    public static readonly LinkDeliveryDeliveryMethod Email = new("EMAIL");

    public static LinkDeliveryDeliveryMethod FromValue(string value) => FromValueCore(value);
}
