using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Indicates the account's categorization as either a personal or a business account. This field is currently in beta; to request access, contact your account manager.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<HolderCategory>))]
public sealed record HolderCategory : OpenStringEnum<HolderCategory>
{
    private HolderCategory(string value) : base(value)
    {
    }

    public static readonly HolderCategory Business = new("business");

    public static readonly HolderCategory Personal = new("personal");

    public static readonly HolderCategory Unrecognized = new("unrecognized");

    public TResult Match<TResult>(Func<TResult> onBusiness,
        Func<TResult> onPersonal,
        Func<TResult> onUnrecognized,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Business => onBusiness(),
            _ when this == Personal => onPersonal(),
            _ when this == Unrecognized => onUnrecognized(),
            _ => otherwise(Value)
        };

    public void Match(Action onBusiness, Action onPersonal, Action onUnrecognized, Action<string> otherwise)
    {
        if (this == Business) onBusiness();
        else if (this == Personal) onPersonal();
        else if (this == Unrecognized) onUnrecognized();
        else otherwise(Value);
    }
}
