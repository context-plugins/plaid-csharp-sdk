using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Identifies the type of a party
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PartyType>))]
public sealed record PartyType : OpenStringEnum<PartyType>
{
    private PartyType(string value) : base(value)
    {
    }

    public static readonly PartyType DataAccessPlatform = new("DATA_ACCESS_PLATFORM");

    public static readonly PartyType DataProvider = new("DATA_PROVIDER");

    public static readonly PartyType DataRecipient = new("DATA_RECIPIENT");

    public static readonly PartyType Individual = new("INDIVIDUAL");

    public static readonly PartyType Merchant = new("MERCHANT");

    public static readonly PartyType Vendor = new("VENDOR");

    public TResult Match<TResult>(Func<TResult> onDataAccessPlatform,
        Func<TResult> onDataProvider,
        Func<TResult> onDataRecipient,
        Func<TResult> onIndividual,
        Func<TResult> onMerchant,
        Func<TResult> onVendor,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == DataAccessPlatform => onDataAccessPlatform(),
            _ when this == DataProvider => onDataProvider(),
            _ when this == DataRecipient => onDataRecipient(),
            _ when this == Individual => onIndividual(),
            _ when this == Merchant => onMerchant(),
            _ when this == Vendor => onVendor(),
            _ => otherwise(Value)
        };

    public void Match(Action onDataAccessPlatform,
        Action onDataProvider,
        Action onDataRecipient,
        Action onIndividual,
        Action onMerchant,
        Action onVendor,
        Action<string> otherwise)
    {
        if (this == DataAccessPlatform) onDataAccessPlatform();
        else if (this == DataProvider) onDataProvider();
        else if (this == DataRecipient) onDataRecipient();
        else if (this == Individual) onIndividual();
        else if (this == Merchant) onMerchant();
        else if (this == Vendor) onVendor();
        else otherwise(Value);
    }
}
