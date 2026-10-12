using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// How Plaid should deliver the Plaid Link session to the customer. Only available to customers enabled for Link Delivery (beta). To request Link Delivery access, contact your account manager.
/// 'sms' will deliver via SMS. Must pass <c>user.phone_number</c>.
/// 'email' will deliver via email. Must pass <c>user.email_address</c>. In the Sandbox environment, this field will be ignored; use the Production environment to test Link Delivery instead.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<HostedLinkDeliveryMethod>))]
public sealed record HostedLinkDeliveryMethod : OpenStringEnum<HostedLinkDeliveryMethod>
{
    private HostedLinkDeliveryMethod(string value) : base(value)
    {
    }

    public static readonly HostedLinkDeliveryMethod Sms = new("sms");

    public static readonly HostedLinkDeliveryMethod Email = new("email");

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
