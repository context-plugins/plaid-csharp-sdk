using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The inquiry type of credit profile report.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CraCreditProfileInquiryType>))]
public sealed record CraCreditProfileInquiryType : OpenStringEnum<CraCreditProfileInquiryType>
{
    private CraCreditProfileInquiryType(string value) : base(value)
    {
    }

    public static readonly CraCreditProfileInquiryType SoftInquiry = new("SOFT_INQUIRY");

    public static readonly CraCreditProfileInquiryType StandardInquiry = new("STANDARD_INQUIRY");

    public TResult Match<TResult>(Func<TResult> onSoftInquiry,
        Func<TResult> onStandardInquiry,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == SoftInquiry => onSoftInquiry(),
            _ when this == StandardInquiry => onStandardInquiry(),
            _ => otherwise(Value)
        };

    public void Match(Action onSoftInquiry, Action onStandardInquiry, Action<string> otherwise)
    {
        if (this == SoftInquiry) onSoftInquiry();
        else if (this == StandardInquiry) onStandardInquiry();
        else otherwise(Value);
    }
}
