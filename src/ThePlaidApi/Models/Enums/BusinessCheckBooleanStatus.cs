using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Tri-state boolean status, where <c>no_data</c> indicates the check could not determine a value.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BusinessCheckBooleanStatus>))]
public sealed record BusinessCheckBooleanStatus : OpenStringEnum<BusinessCheckBooleanStatus>
{
    private BusinessCheckBooleanStatus(string value) : base(value)
    {
    }

    public static readonly BusinessCheckBooleanStatus Yes = new("yes");

    public static readonly BusinessCheckBooleanStatus No = new("no");

    public static readonly BusinessCheckBooleanStatus NoData = new("no_data");

    public TResult Match<TResult>(Func<TResult> onYes,
        Func<TResult> onNo,
        Func<TResult> onNoData,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Yes => onYes(),
            _ when this == No => onNo(),
            _ when this == NoData => onNoData(),
            _ => otherwise(Value)
        };

    public void Match(Action onYes, Action onNo, Action onNoData, Action<string> otherwise)
    {
        if (this == Yes) onYes();
        else if (this == No) onNo();
        else if (this == NoData) onNoData();
        else otherwise(Value);
    }
}
