using System;
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
public sealed record EnrichTransactionDirection : OpenStringEnum<EnrichTransactionDirection>
{
    private EnrichTransactionDirection(string value) : base(value)
    {
    }

    public static readonly EnrichTransactionDirection Inflow = new("INFLOW");

    public static readonly EnrichTransactionDirection Outflow = new("OUTFLOW");

    public TResult Match<TResult>(Func<TResult> onInflow, Func<TResult> onOutflow, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Inflow => onInflow(),
            _ when this == Outflow => onOutflow(),
            _ => otherwise(Value)
        };

    public void Match(Action onInflow, Action onOutflow, Action<string> otherwise)
    {
        if (this == Inflow) onInflow();
        else if (this == Outflow) onOutflow();
        else otherwise(Value);
    }
}
