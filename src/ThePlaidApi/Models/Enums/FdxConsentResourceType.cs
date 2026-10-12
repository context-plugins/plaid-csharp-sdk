using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Type of resource permissioned on a consent grant.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FdxConsentResourceType>))]
public sealed record FdxConsentResourceType : OpenStringEnum<FdxConsentResourceType>
{
    private FdxConsentResourceType(string value) : base(value)
    {
    }

    public static readonly FdxConsentResourceType Account = new("ACCOUNT");

    public static readonly FdxConsentResourceType Customer = new("CUSTOMER");

    public static readonly FdxConsentResourceType Document = new("DOCUMENT");

    public TResult Match<TResult>(Func<TResult> onAccount,
        Func<TResult> onCustomer,
        Func<TResult> onDocument,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Account => onAccount(),
            _ when this == Customer => onCustomer(),
            _ when this == Document => onDocument(),
            _ => otherwise(Value)
        };

    public void Match(Action onAccount, Action onCustomer, Action onDocument, Action<string> otherwise)
    {
        if (this == Account) onAccount();
        else if (this == Customer) onCustomer();
        else if (this == Document) onDocument();
        else otherwise(Value);
    }
}
