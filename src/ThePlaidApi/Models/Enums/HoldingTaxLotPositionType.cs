using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Indicates whether a holding lot position is long or short. Possible values are <c>LONG</c> and <c>SHORT</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<HoldingTaxLotPositionType>))]
public sealed record HoldingTaxLotPositionType : OpenStringEnum<HoldingTaxLotPositionType>
{
    private HoldingTaxLotPositionType(string value) : base(value)
    {
    }

    public static readonly HoldingTaxLotPositionType Long = new("LONG");

    public static readonly HoldingTaxLotPositionType Short = new("SHORT");

    public TResult Match<TResult>(Func<TResult> onLong, Func<TResult> onShort, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Long => onLong(),
            _ when this == Short => onShort(),
            _ => otherwise(Value)
        };

    public void Match(Action onLong, Action onShort, Action<string> otherwise)
    {
        if (this == Long) onLong();
        else if (this == Short) onShort();
        else otherwise(Value);
    }
}
