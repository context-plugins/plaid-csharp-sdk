using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The status of the wallet.
/// <para>
/// <c>UNKNOWN</c>: The wallet status is unknown.
/// </para>
/// <para>
/// <c>ACTIVE</c>: The wallet is active and ready to send money to and receive money from.
/// </para>
/// <para>
/// <c>CLOSED</c>: The wallet is closed. Any transactions made to or from this wallet will error.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<WalletStatus>))]
public sealed record WalletStatus : OpenStringEnum<WalletStatus>
{
    private WalletStatus(string value) : base(value)
    {
    }

    public static readonly WalletStatus Unknown = new("UNKNOWN");

    public static readonly WalletStatus Active = new("ACTIVE");

    public static readonly WalletStatus Closed = new("CLOSED");

    public TResult Match<TResult>(Func<TResult> onUnknown,
        Func<TResult> onActive,
        Func<TResult> onClosed,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Unknown => onUnknown(),
            _ when this == Active => onActive(),
            _ when this == Closed => onClosed(),
            _ => otherwise(Value)
        };

    public void Match(Action onUnknown, Action onActive, Action onClosed, Action<string> otherwise)
    {
        if (this == Unknown) onUnknown();
        else if (this == Active) onActive();
        else if (this == Closed) onClosed();
        else otherwise(Value);
    }
}
