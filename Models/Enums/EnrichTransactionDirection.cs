using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The direction of the transaction from the perspective of the account holder:
/// <para>
/// <c>OUTFLOW</c> - Includes outgoing transfers, purchases, and fees. (Typically represented as a negative value on checking accounts and debit cards and a positive value on credit cards.)
/// </para>
/// <para>
/// <c>INFLOW</c> - Includes incoming transfers, refunds, and income. (Typically represented as a positive value on checking accounts and debit cards and a negative value on credit cards.)
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<EnrichTransactionDirection>))]
public sealed record EnrichTransactionDirection : StringEnum<EnrichTransactionDirection>
{
    private EnrichTransactionDirection(string value) : base(value)
    {
    }

    public static readonly EnrichTransactionDirection Inflow = new("INFLOW");

    public static readonly EnrichTransactionDirection Outflow = new("OUTFLOW");

    public static EnrichTransactionDirection FromValue(string value) => FromValueCore(value);
}
