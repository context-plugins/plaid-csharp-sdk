using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// <c>digital:</c> transactions that took place online.
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
[JsonConverter(typeof(StringEnumConverter<AssetReportTransactionType>))]
public sealed record AssetReportTransactionType : StringEnum<AssetReportTransactionType>
{
    private AssetReportTransactionType(string value) : base(value)
    {
    }

    public static readonly AssetReportTransactionType Digital = new("digital");

    public static readonly AssetReportTransactionType Place = new("place");

    public static readonly AssetReportTransactionType Special = new("special");

    public static readonly AssetReportTransactionType Unresolved = new("unresolved");

    public static AssetReportTransactionType FromValue(string value) => FromValueCore(value);
}
