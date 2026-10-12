using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Build status of the business website.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BusinessWebsiteBuildStatus>))]
public sealed record BusinessWebsiteBuildStatus : OpenStringEnum<BusinessWebsiteBuildStatus>
{
    private BusinessWebsiteBuildStatus(string value) : base(value)
    {
    }

    public static readonly BusinessWebsiteBuildStatus ComingSoon = new("coming_soon");

    public static readonly BusinessWebsiteBuildStatus Active = new("active");

    public static readonly BusinessWebsiteBuildStatus Inactive = new("inactive");

    public TResult Match<TResult>(Func<TResult> onComingSoon,
        Func<TResult> onActive,
        Func<TResult> onInactive,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ComingSoon => onComingSoon(),
            _ when this == Active => onActive(),
            _ when this == Inactive => onInactive(),
            _ => otherwise(Value)
        };

    public void Match(Action onComingSoon, Action onActive, Action onInactive, Action<string> otherwise)
    {
        if (this == ComingSoon) onComingSoon();
        else if (this == Active) onActive();
        else if (this == Inactive) onInactive();
        else otherwise(Value);
    }
}
