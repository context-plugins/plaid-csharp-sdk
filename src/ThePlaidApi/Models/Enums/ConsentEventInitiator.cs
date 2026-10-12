using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The entity that initiated collection of consent.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ConsentEventInitiator>))]
public sealed record ConsentEventInitiator : OpenStringEnum<ConsentEventInitiator>
{
    private ConsentEventInitiator(string value) : base(value)
    {
    }

    public static readonly ConsentEventInitiator Plaid = new("PLAID");

    public static readonly ConsentEventInitiator DataProvider = new("DATA_PROVIDER");

    public static readonly ConsentEventInitiator Customer = new("CUSTOMER");

    public static readonly ConsentEventInitiator EndUser = new("END_USER");

    public TResult Match<TResult>(Func<TResult> onPlaid,
        Func<TResult> onDataProvider,
        Func<TResult> onCustomer,
        Func<TResult> onEndUser,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Plaid => onPlaid(),
            _ when this == DataProvider => onDataProvider(),
            _ when this == Customer => onCustomer(),
            _ when this == EndUser => onEndUser(),
            _ => otherwise(Value)
        };

    public void Match(Action onPlaid,
        Action onDataProvider,
        Action onCustomer,
        Action onEndUser,
        Action<string> otherwise)
    {
        if (this == Plaid) onPlaid();
        else if (this == DataProvider) onDataProvider();
        else if (this == Customer) onCustomer();
        else if (this == EndUser) onEndUser();
        else otherwise(Value);
    }
}
