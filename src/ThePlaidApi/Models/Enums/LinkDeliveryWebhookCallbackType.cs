using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The type of Link callback event
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LinkDeliveryWebhookCallbackType>))]
public sealed record LinkDeliveryWebhookCallbackType : OpenStringEnum<LinkDeliveryWebhookCallbackType>
{
    private LinkDeliveryWebhookCallbackType(string value) : base(value)
    {
    }

    public static readonly LinkDeliveryWebhookCallbackType OnSuccess = new("ON_SUCCESS");

    public static readonly LinkDeliveryWebhookCallbackType OnEvent = new("ON_EVENT");

    public static readonly LinkDeliveryWebhookCallbackType OnExit = new("ON_EXIT");

    public TResult Match<TResult>(Func<TResult> onOnSuccess,
        Func<TResult> onOnEvent,
        Func<TResult> onOnExit,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == OnSuccess => onOnSuccess(),
            _ when this == OnEvent => onOnEvent(),
            _ when this == OnExit => onOnExit(),
            _ => otherwise(Value)
        };

    public void Match(Action onOnSuccess, Action onOnEvent, Action onOnExit, Action<string> otherwise)
    {
        if (this == OnSuccess) onOnSuccess();
        else if (this == OnEvent) onOnEvent();
        else if (this == OnExit) onOnExit();
        else otherwise(Value);
    }
}
