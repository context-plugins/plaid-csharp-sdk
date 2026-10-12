using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Decides the mode under which the payment processing should be performed, using <c>IMMEDIATE</c> as default.
/// <para>
/// <c>IMMEDIATE</c>: Will immediately execute the payment, waiting for a response from the ASPSP before returning the result of the payment initiation. This is ideal for user-present flows.
/// </para>
/// <para>
///  <c>ASYNC</c>: Will accept a payment execution request and schedule it for processing, immediately returning the new <c>payment_id</c>. Listen for webhooks to obtain real-time updates on the payment status. This is ideal for non user-present flows.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PaymentInitiationConsentProcessingMode>))]
public sealed record PaymentInitiationConsentProcessingMode : OpenStringEnum<PaymentInitiationConsentProcessingMode>
{
    private PaymentInitiationConsentProcessingMode(string value) : base(value)
    {
    }

    public static readonly PaymentInitiationConsentProcessingMode Async = new("ASYNC");

    public static readonly PaymentInitiationConsentProcessingMode Immediate = new("IMMEDIATE");

    public TResult Match<TResult>(Func<TResult> onAsync, Func<TResult> onImmediate, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Async => onAsync(),
            _ when this == Immediate => onImmediate(),
            _ => otherwise(Value)
        };

    public void Match(Action onAsync, Action onImmediate, Action<string> otherwise)
    {
        if (this == Async) onAsync();
        else if (this == Immediate) onImmediate();
        else otherwise(Value);
    }
}
