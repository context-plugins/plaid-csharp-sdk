using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The inquiry type of credit profile report.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CraCreditProfileInquiryType>))]
public sealed record CraCreditProfileInquiryType : StringEnum<CraCreditProfileInquiryType>
{
    private CraCreditProfileInquiryType(string value) : base(value)
    {
    }

    public static readonly CraCreditProfileInquiryType SoftInquiry = new("SOFT_INQUIRY");

    public static readonly CraCreditProfileInquiryType StandardInquiry = new("STANDARD_INQUIRY");

    public static CraCreditProfileInquiryType FromValue(string value) => FromValueCore(value);
}
