using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A description of whether the associated document was expired when the verification was performed.
/// <para>
/// Note: In the case where an expiration date is not present on the document or failed to be extracted, this value will be <c>no_data</c>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ExpirationDate>))]
public sealed record ExpirationDate : OpenStringEnum<ExpirationDate>
{
    private ExpirationDate(string value) : base(value)
    {
    }

    public static readonly ExpirationDate NotExpired = new("not_expired");

    public static readonly ExpirationDate Expired = new("expired");

    public static readonly ExpirationDate NoData = new("no_data");

    public TResult Match<TResult>(Func<TResult> onNotExpired,
        Func<TResult> onExpired,
        Func<TResult> onNoData,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == NotExpired => onNotExpired(),
            _ when this == Expired => onExpired(),
            _ when this == NoData => onNoData(),
            _ => otherwise(Value)
        };

    public void Match(Action onNotExpired, Action onExpired, Action onNoData, Action<string> otherwise)
    {
        if (this == NotExpired) onNotExpired();
        else if (this == Expired) onExpired();
        else if (this == NoData) onNoData();
        else otherwise(Value);
    }
}
