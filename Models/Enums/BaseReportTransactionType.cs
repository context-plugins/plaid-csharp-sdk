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
/// <c>unresolved:</c> transactions that do not fit into the other types.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BaseReportTransactionType>))]
public sealed record BaseReportTransactionType : StringEnum<BaseReportTransactionType>
{
    private BaseReportTransactionType(string value) : base(value)
    {
    }

    public static readonly BaseReportTransactionType Digital = new("digital");

    public static readonly BaseReportTransactionType Place = new("place");

    public static readonly BaseReportTransactionType Special = new("special");

    public static readonly BaseReportTransactionType Unresolved = new("unresolved");

    public static BaseReportTransactionType FromValue(string value) => FromValueCore(value);
}
