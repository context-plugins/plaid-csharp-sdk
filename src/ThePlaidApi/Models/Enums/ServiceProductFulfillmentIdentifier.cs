using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Documentation not found in the MISMO model viewer and not provided by Freddie Mac.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ServiceProductFulfillmentIdentifier>))]
public sealed record ServiceProductFulfillmentIdentifier : OpenStringEnum<ServiceProductFulfillmentIdentifier>
{
    private ServiceProductFulfillmentIdentifier(string value) : base(value)
    {
    }

    public static readonly ServiceProductFulfillmentIdentifier Voa = new("VOA");

    public static readonly ServiceProductFulfillmentIdentifier Voe = new("VOE");

    public TResult Match<TResult>(Func<TResult> onVoa, Func<TResult> onVoe, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Voa => onVoa(),
            _ when this == Voe => onVoe(),
            _ => otherwise(Value)
        };

    public void Match(Action onVoa, Action onVoe, Action<string> otherwise)
    {
        if (this == Voa) onVoa();
        else if (this == Voe) onVoe();
        else otherwise(Value);
    }
}
