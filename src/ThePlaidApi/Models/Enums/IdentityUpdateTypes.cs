using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The possible types of identity data that may have changed.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<IdentityUpdateTypes>))]
public sealed record IdentityUpdateTypes : OpenStringEnum<IdentityUpdateTypes>
{
    private IdentityUpdateTypes(string value) : base(value)
    {
    }

    public static readonly IdentityUpdateTypes Phones = new("PHONES");

    public static readonly IdentityUpdateTypes Addresses = new("ADDRESSES");

    public static readonly IdentityUpdateTypes Emails = new("EMAILS");

    public static readonly IdentityUpdateTypes Names = new("NAMES");

    public TResult Match<TResult>(Func<TResult> onPhones,
        Func<TResult> onAddresses,
        Func<TResult> onEmails,
        Func<TResult> onNames,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Phones => onPhones(),
            _ when this == Addresses => onAddresses(),
            _ when this == Emails => onEmails(),
            _ when this == Names => onNames(),
            _ => otherwise(Value)
        };

    public void Match(Action onPhones, Action onAddresses, Action onEmails, Action onNames, Action<string> otherwise)
    {
        if (this == Phones) onPhones();
        else if (this == Addresses) onAddresses();
        else if (this == Emails) onEmails();
        else if (this == Names) onNames();
        else otherwise(Value);
    }
}
