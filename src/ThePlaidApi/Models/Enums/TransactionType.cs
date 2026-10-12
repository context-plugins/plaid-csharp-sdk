using System;
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
public sealed record TransactionType : OpenStringEnum<TransactionType>
{
    private TransactionType(string value) : base(value)
    {
    }

    public static readonly TransactionType Digital = new("digital");

    public static readonly TransactionType Place = new("place");

    public static readonly TransactionType Special = new("special");

    public static readonly TransactionType Unresolved = new("unresolved");

    public TResult Match<TResult>(Func<TResult> onDigital,
        Func<TResult> onPlace,
        Func<TResult> onSpecial,
        Func<TResult> onUnresolved,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Digital => onDigital(),
            _ when this == Place => onPlace(),
            _ when this == Special => onSpecial(),
            _ when this == Unresolved => onUnresolved(),
            _ => otherwise(Value)
        };

    public void Match(Action onDigital, Action onPlace, Action onSpecial, Action onUnresolved, Action<string> otherwise)
    {
        if (this == Digital) onDigital();
        else if (this == Place) onPlace();
        else if (this == Special) onSpecial();
        else if (this == Unresolved) onUnresolved();
        else otherwise(Value);
    }
}
