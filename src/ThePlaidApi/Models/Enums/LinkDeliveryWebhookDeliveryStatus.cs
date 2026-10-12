using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The status of the delivery of the Hosted Link to the user
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LinkDeliveryWebhookDeliveryStatus>))]
public sealed record LinkDeliveryWebhookDeliveryStatus : OpenStringEnum<LinkDeliveryWebhookDeliveryStatus>
{
    private LinkDeliveryWebhookDeliveryStatus(string value) : base(value)
    {
    }

    public static readonly LinkDeliveryWebhookDeliveryStatus Success = new("SUCCESS");

    public static readonly LinkDeliveryWebhookDeliveryStatus Failure = new("FAILURE");

    public TResult Match<TResult>(Func<TResult> onSuccess, Func<TResult> onFailure, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Success => onSuccess(),
            _ when this == Failure => onFailure(),
            _ => otherwise(Value)
        };

    public void Match(Action onSuccess, Action onFailure, Action<string> otherwise)
    {
        if (this == Success) onSuccess();
        else if (this == Failure) onFailure();
        else otherwise(Value);
    }
}
