using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A field that may be required to be submitted for enablement.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PartnerEndCustomerRequirementDue>))]
public sealed record PartnerEndCustomerRequirementDue : OpenStringEnum<PartnerEndCustomerRequirementDue>
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

    public TResult Match<TResult>(Func<TResult> onLegalEntityName,
        Func<TResult> onWebsite,
        Func<TResult> onApplicationName,
        Func<TResult> onIsDiligenceAttested,
        Func<TResult> onTechnicalContact,
        Func<TResult> onBillingContact,
        Func<TResult> onAddress,
        Func<TResult> onBankAddendumAcceptance,
        Func<TResult> onQuestionnairesCra,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == LegalEntityName => onLegalEntityName(),
            _ when this == Website => onWebsite(),
            _ when this == ApplicationName => onApplicationName(),
            _ when this == IsDiligenceAttested => onIsDiligenceAttested(),
            _ when this == TechnicalContact => onTechnicalContact(),
            _ when this == BillingContact => onBillingContact(),
            _ when this == Address => onAddress(),
            _ when this == BankAddendumAcceptance => onBankAddendumAcceptance(),
            _ when this == QuestionnairesCra => onQuestionnairesCra(),
            _ => otherwise(Value)
        };

    public void Match(Action onLegalEntityName,
        Action onWebsite,
        Action onApplicationName,
        Action onIsDiligenceAttested,
        Action onTechnicalContact,
        Action onBillingContact,
        Action onAddress,
        Action onBankAddendumAcceptance,
        Action onQuestionnairesCra,
        Action<string> otherwise)
    {
        if (this == LegalEntityName) onLegalEntityName();
        else if (this == Website) onWebsite();
        else if (this == ApplicationName) onApplicationName();
        else if (this == IsDiligenceAttested) onIsDiligenceAttested();
        else if (this == TechnicalContact) onTechnicalContact();
        else if (this == BillingContact) onBillingContact();
        else if (this == Address) onAddress();
        else if (this == BankAddendumAcceptance) onBankAddendumAcceptance();
        else if (this == QuestionnairesCra) onQuestionnairesCra();
        else otherwise(Value);
    }
}
