using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The result of the statement refresh extraction
/// <para>
/// <c>SUCCESS</c>: The statements were successfully extracted and can be listed via <c>/statements/list</c> and downloaded via <c>/statements/download</c>.
/// </para>
/// <para>
/// <c>FAILURE</c>: The statements failed to be extracted.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<StatementsRefreshCompleteResult>))]
public sealed record StatementsRefreshCompleteResult : OpenStringEnum<StatementsRefreshCompleteResult>
{
    private StatementsRefreshCompleteResult(string value) : base(value)
    {
    }

    public static readonly StatementsRefreshCompleteResult Success = new("SUCCESS");

    public static readonly StatementsRefreshCompleteResult Failure = new("FAILURE");

    public TResult Match<TResult>(Func<TResult> onSuccess, Func<TResult> onFailure, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Success => onSuccess(),
            _ when this == Failure => onFailure(),
            _ => otherwise(Value)
        };

    public void Match(Action onSuccess, Action onFailure, Action<string> otherwise)
    {
        if (this == Success) onSuccess();
        else if (this == Failure) onFailure();
        else otherwise(Value);
    }
}
