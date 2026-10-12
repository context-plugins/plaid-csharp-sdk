using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Enum representing the entity authenticating the user.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ItemCreateAuthentication>))]
public sealed record ItemCreateAuthentication : OpenStringEnum<ItemCreateAuthentication>
{
    private ItemCreateAuthentication(string value) : base(value)
    {
    }

    public static readonly ItemCreateAuthentication Unknown = new("UNKNOWN");

    public static readonly ItemCreateAuthentication DataPartner = new("DATA_PARTNER");

    public static readonly ItemCreateAuthentication Plaid = new("PLAID");

    public TResult Match<TResult>(Func<TResult> onUnknown,
        Func<TResult> onDataPartner,
        Func<TResult> onPlaid,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Unknown => onUnknown(),
            _ when this == DataPartner => onDataPartner(),
            _ when this == Plaid => onPlaid(),
            _ => otherwise(Value)
        };

    public void Match(Action onUnknown, Action onDataPartner, Action onPlaid, Action<string> otherwise)
    {
        if (this == Unknown) onUnknown();
        else if (this == DataPartner) onDataPartner();
        else if (this == Plaid) onPlaid();
        else otherwise(Value);
    }
}
