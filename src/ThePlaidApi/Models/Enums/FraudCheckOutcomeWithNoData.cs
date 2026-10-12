using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The outcome of the fraud check.
/// <para>
///
/// <c>success</c> - The check passed.
/// </para>
/// <para>
/// <c>failed</c> - The check did not pass.
/// </para>
/// <para>
/// <c>no_data</c> - The check could not be performed due to insufficient data.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FraudCheckOutcomeWithNoData>))]
public sealed record FraudCheckOutcomeWithNoData : OpenStringEnum<FraudCheckOutcomeWithNoData>
{
    private FraudCheckOutcomeWithNoData(string value) : base(value)
    {
    }

    public static readonly FraudCheckOutcomeWithNoData Success = new("success");

    public static readonly FraudCheckOutcomeWithNoData Failed = new("failed");

    public static readonly FraudCheckOutcomeWithNoData NoData = new("no_data");

    public TResult Match<TResult>(Func<TResult> onSuccess,
        Func<TResult> onFailed,
        Func<TResult> onNoData,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Success => onSuccess(),
            _ when this == Failed => onFailed(),
            _ when this == NoData => onNoData(),
            _ => otherwise(Value)
        };

    public void Match(Action onSuccess, Action onFailed, Action onNoData, Action<string> otherwise)
    {
        if (this == Success) onSuccess();
        else if (this == Failed) onFailed();
        else if (this == NoData) onNoData();
        else otherwise(Value);
    }
}
