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
public sealed record WalletStatus : StringEnum<WalletStatus>
{
    private WalletStatus(string value) : base(value)
    {
    }

    public static readonly WalletStatus Unknown = new("UNKNOWN");

    public static readonly WalletStatus Active = new("ACTIVE");

    public static readonly WalletStatus Closed = new("CLOSED");

    public static WalletStatus FromValue(string value) => FromValueCore(value);
}
