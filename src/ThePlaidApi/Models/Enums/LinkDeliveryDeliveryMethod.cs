using System;
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
public sealed record LinkDeliveryDeliveryMethod : OpenStringEnum<LinkDeliveryDeliveryMethod>
{
    private LinkDeliveryDeliveryMethod(string value) : base(value)
    {
    }

    public static readonly LinkDeliveryDeliveryMethod Sms = new("SMS");

    public static readonly LinkDeliveryDeliveryMethod Email = new("EMAIL");

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
