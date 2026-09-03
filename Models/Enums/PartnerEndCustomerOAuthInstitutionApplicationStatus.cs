using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The registration status for the end customer's application.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PartnerEndCustomerOAuthInstitutionApplicationStatus>))]
public sealed record PartnerEndCustomerOAuthInstitutionApplicationStatus : StringEnum<PartnerEndCustomerOAuthInstitutionApplicationStatus>
{
    private PartnerEndCustomerOAuthInstitutionApplicationStatus(string value) : base(value)
    {
    }

    public static readonly PartnerEndCustomerOAuthInstitutionApplicationStatus NotStarted = new("NOT_STARTED");

    public static readonly PartnerEndCustomerOAuthInstitutionApplicationStatus Processing = new("PROCESSING");

    public static readonly PartnerEndCustomerOAuthInstitutionApplicationStatus Approved = new("APPROVED");

    public static readonly PartnerEndCustomerOAuthInstitutionApplicationStatus Enabled = new("ENABLED");

    public static readonly PartnerEndCustomerOAuthInstitutionApplicationStatus AttentionRequired = new("ATTENTION_REQUIRED");

    public static PartnerEndCustomerOAuthInstitutionApplicationStatus FromValue(string value) =>
        FromValueCore(value);
}
