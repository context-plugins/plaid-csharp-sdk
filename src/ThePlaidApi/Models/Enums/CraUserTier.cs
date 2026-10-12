using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The tier of the user.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CraUserTier>))]
public sealed record CraUserTier : OpenStringEnum<CraUserTier>
{
    private CraUserTier(string value) : base(value)
    {
    }

    public static readonly CraUserTier Free = new("free");

    public static readonly CraUserTier Paid = new("paid");

    public TResult Match<TResult>(Func<TResult> onFree, Func<TResult> onPaid, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Free => onFree(),
            _ when this == Paid => onPaid(),
            _ => otherwise(Value)
        };

    public void Match(Action onFree, Action onPaid, Action<string> otherwise)
    {
        if (this == Free) onFree();
        else if (this == Paid) onPaid();
        else otherwise(Value);
    }
}
