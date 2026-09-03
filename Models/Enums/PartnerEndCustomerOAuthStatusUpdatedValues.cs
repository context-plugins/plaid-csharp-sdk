using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The OAuth status of the update
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PartnerEndCustomerOAuthStatusUpdatedValues>))]
public sealed record PartnerEndCustomerOAuthStatusUpdatedValues : StringEnum<PartnerEndCustomerOAuthStatusUpdatedValues>
{
    private PartnerEndCustomerOAuthStatusUpdatedValues(string value) : base(value)
    {
    }

    public static readonly PartnerEndCustomerOAuthStatusUpdatedValues NotStarted = new("not-started");

    public static readonly PartnerEndCustomerOAuthStatusUpdatedValues Processing = new("processing");

    public static readonly PartnerEndCustomerOAuthStatusUpdatedValues Approved = new("approved");

    public static readonly PartnerEndCustomerOAuthStatusUpdatedValues Enabled = new("enabled");

    public static readonly PartnerEndCustomerOAuthStatusUpdatedValues AttentionRequired = new("attention-required");

    public static PartnerEndCustomerOAuthStatusUpdatedValues FromValue(string value) => FromValueCore(value);
}
