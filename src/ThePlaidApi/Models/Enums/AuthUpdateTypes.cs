using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The possible types of auth data that may have changed.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AuthUpdateTypes>))]
public sealed record AuthUpdateTypes : OpenStringEnum<AuthUpdateTypes>
{
    private AuthUpdateTypes(string value) : base(value)
    {
    }

    public static readonly AuthUpdateTypes AccountNumber = new("ACCOUNT_NUMBER");

    public static readonly AuthUpdateTypes RoutingNumber = new("ROUTING_NUMBER");

    public TResult Match<TResult>(Func<TResult> onAccountNumber,
        Func<TResult> onRoutingNumber,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AccountNumber => onAccountNumber(),
            _ when this == RoutingNumber => onRoutingNumber(),
            _ => otherwise(Value)
        };

    public void Match(Action onAccountNumber, Action onRoutingNumber, Action<string> otherwise)
    {
        if (this == AccountNumber) onAccountNumber();
        else if (this == RoutingNumber) onRoutingNumber();
        else otherwise(Value);
    }
}
