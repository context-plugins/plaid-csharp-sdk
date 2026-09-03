using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The type of balance to which the APR applies.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AprType>))]
public sealed record AprType : StringEnum<AprType>
{
    private AprType(string value) : base(value)
    {
    }

    public static readonly AprType BalanceTransferApr = new("balance_transfer_apr");

    public static readonly AprType CashApr = new("cash_apr");

    public static readonly AprType PurchaseApr = new("purchase_apr");

    public static readonly AprType Special = new("special");

    public static AprType FromValue(string value) => FromValueCore(value);
}
