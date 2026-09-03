using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Please use the <c>payment_channel</c> field, <c>transaction_type</c> will be deprecated in the future.
/// <para>
/// <c>digital:</c> transactions that took place online.
/// </para>
/// <para>
/// <c>place:</c> transactions that were made at a physical location.
/// </para>
/// <para>
/// <c>special:</c> transactions that relate to banks, e.g. fees or deposits.
/// </para>
/// <para>
/// <c>unresolved:</c> transactions that do not fit into the other three types.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransactionType>))]
public sealed record TransactionType : StringEnum<TransactionType>
{
    private TransactionType(string value) : base(value)
    {
    }

    public static readonly TransactionType Digital = new("digital");

    public static readonly TransactionType Place = new("place");

    public static readonly TransactionType Special = new("special");

    public static readonly TransactionType Unresolved = new("unresolved");

    public static TransactionType FromValue(string value) => FromValueCore(value);
}
