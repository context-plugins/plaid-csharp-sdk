using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Indicates the direction of the transfer: <c>outbound</c> for API-initiated transfers, or <c>inbound</c> for payments received by the FBO account.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BankTransferDirection>))]
public sealed record BankTransferDirection : OpenStringEnum<BankTransferDirection>
{
    private BankTransferDirection(string value) : base(value)
    {
    }

    public static readonly BankTransferDirection Outbound = new("outbound");

    public static readonly BankTransferDirection Inbound = new("inbound");

    public TResult Match<TResult>(Func<TResult> onOutbound, Func<TResult> onInbound, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Outbound => onOutbound(),
            _ when this == Inbound => onInbound(),
            _ => otherwise(Value)
        };

    public void Match(Action onOutbound, Action onInbound, Action<string> otherwise)
    {
        if (this == Outbound) onOutbound();
        else if (this == Inbound) onInbound();
        else otherwise(Value);
    }
}
