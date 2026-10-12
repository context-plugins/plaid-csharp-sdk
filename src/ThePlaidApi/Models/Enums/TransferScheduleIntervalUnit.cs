using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The unit of the recurring interval.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransferScheduleIntervalUnit>))]
public sealed record TransferScheduleIntervalUnit : OpenStringEnum<TransferScheduleIntervalUnit>
{
    private TransferScheduleIntervalUnit(string value) : base(value)
    {
    }

    public static readonly TransferScheduleIntervalUnit Week = new("week");

    public static readonly TransferScheduleIntervalUnit Month = new("month");

    public TResult Match<TResult>(Func<TResult> onWeek, Func<TResult> onMonth, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Week => onWeek(),
            _ when this == Month => onMonth(),
            _ => otherwise(Value)
        };

    public void Match(Action onWeek, Action onMonth, Action<string> otherwise)
    {
        if (this == Week) onWeek();
        else if (this == Month) onMonth();
        else otherwise(Value);
    }
}
