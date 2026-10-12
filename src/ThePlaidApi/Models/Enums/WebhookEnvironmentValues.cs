using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The Plaid environment the webhook was sent from
/// </summary>
[JsonConverter(typeof(StringEnumConverter<WebhookEnvironmentValues>))]
public sealed record WebhookEnvironmentValues : OpenStringEnum<WebhookEnvironmentValues>
{
    private WebhookEnvironmentValues(string value) : base(value)
    {
    }

    public static readonly WebhookEnvironmentValues Sandbox = new("sandbox");

    public static readonly WebhookEnvironmentValues Production = new("production");

    public TResult Match<TResult>(Func<TResult> onSandbox,
        Func<TResult> onProduction,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Sandbox => onSandbox(),
            _ when this == Production => onProduction(),
            _ => otherwise(Value)
        };

    public void Match(Action onSandbox, Action onProduction, Action<string> otherwise)
    {
        if (this == Sandbox) onSandbox();
        else if (this == Production) onProduction();
        else otherwise(Value);
    }
}
