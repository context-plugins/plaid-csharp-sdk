using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A field that may be required to be submitted for enablement.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PartnerEndCustomerRequirementDue>))]
public sealed record PartnerEndCustomerRequirementDue : StringEnum<PartnerEndCustomerRequirementDue>
{
    private PartnerEndCustomerRequirementDue(string value) : base(value)
    {
    }

    public static readonly PartnerEndCustomerRequirementDue LegalEntityName = new("legal_entity_name");

    public static readonly PartnerEndCustomerRequirementDue Website = new("website");

    public static readonly PartnerEndCustomerRequirementDue ApplicationName = new("application_name");

    public static readonly PartnerEndCustomerRequirementDue IsDiligenceAttested = new("is_diligence_attested");

    public static readonly PartnerEndCustomerRequirementDue TechnicalContact = new("technical_contact");

    public static readonly PartnerEndCustomerRequirementDue BillingContact = new("billing_contact");

    public static readonly PartnerEndCustomerRequirementDue Address = new("address");

    public static readonly PartnerEndCustomerRequirementDue BankAddendumAcceptance = new("bank_addendum_acceptance");

    public static readonly PartnerEndCustomerRequirementDue QuestionnairesCra = new("questionnaires.cra");

    public static PartnerEndCustomerRequirementDue FromValue(string value) => FromValueCore(value);
}
