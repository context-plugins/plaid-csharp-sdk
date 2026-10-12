using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The outcome of the human review check, when available. The following values are possible:
/// <para>
///
/// <c>success</c> - The document passed the check.
/// </para>
/// <para>
/// <c>failed</c> - The document failed the check.
/// </para>
/// <para>
/// <c>no_data</c> - The document was submitted, but the document specialist review was not completed in time.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<HumanReviewStatus>))]
public sealed record HumanReviewStatus : OpenStringEnum<HumanReviewStatus>
{
    private HumanReviewStatus(string value) : base(value)
    {
    }

    public static readonly HumanReviewStatus Success = new("success");

    public static readonly HumanReviewStatus Failed = new("failed");

    public static readonly HumanReviewStatus NoData = new("no_data");

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
