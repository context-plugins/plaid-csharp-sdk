using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The communication method used to deliver the Hosted Link session
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LinkDeliveryWebhookCommunicationMethod>))]
public sealed record LinkDeliveryWebhookCommunicationMethod : OpenStringEnum<LinkDeliveryWebhookCommunicationMethod>
{
    private LinkDeliveryWebhookCommunicationMethod(string value) : base(value)
    {
    }

    public static readonly LinkDeliveryWebhookCommunicationMethod Sms = new("SMS");

    public static readonly LinkDeliveryWebhookCommunicationMethod Email = new("EMAIL");

    public TResult Match<TResult>(Func<TResult> onSms, Func<TResult> onEmail, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Sms => onSms(),
            _ when this == Email => onEmail(),
            _ => otherwise(Value)
        };

    public void Match(Action onSms, Action onEmail, Action<string> otherwise)
    {
        if (this == Sms) onSms();
        else if (this == Email) onEmail();
        else otherwise(Value);
    }
}
