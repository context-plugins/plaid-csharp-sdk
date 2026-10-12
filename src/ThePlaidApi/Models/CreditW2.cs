using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// W2 is an object that represents income data taken from a W2 tax document.
/// </summary>
public record CreditW2
{
    /// <summary>
    /// Object representing metadata pertaining to the document.
    /// </summary>
    [JsonPropertyName("document_metadata")]
    public required CreditDocumentMetadata DocumentMetadata { get; init; }

    /// <summary>
    /// An identifier of the document referenced by the document metadata.
    /// </summary>
    [JsonPropertyName("document_id")]
    public required string DocumentId { get; init; }

    /// <summary>
    /// Information about the employer on the pay stub.
    /// </summary>
    [JsonPropertyName("employer")]
    public required CreditPayStubEmployer Employer { get; init; }

    /// <summary>
    /// Data about the employee.
    /// </summary>
    [JsonPropertyName("employee")]
    public required CreditPayStubEmployee Employee { get; init; }

    /// <summary>
    /// The tax year of the W2 document.
    /// </summary>
    [JsonPropertyName("tax_year")]
    public required string? TaxYear { get; init; }

    /// <summary>
    /// An employer identification number or EIN.
    /// </summary>
    [JsonPropertyName("employer_id_number")]
    public required string? EmployerIdNumber { get; init; }

    /// <summary>
    /// Wages from tips and other compensation.
    /// </summary>
    [JsonPropertyName("wages_tips_other_comp")]
    public required string? WagesTipsOtherComp { get; init; }

    /// <summary>
    /// Federal income tax withheld for the tax year.
    /// </summary>
    [JsonPropertyName("federal_income_tax_withheld")]
    public required string? FederalIncomeTaxWithheld { get; init; }

    /// <summary>
    /// Wages from Social Security.
    /// </summary>
    [JsonPropertyName("social_security_wages")]
    public required string? SocialSecurityWages { get; init; }

    /// <summary>
    /// Social Security tax withheld for the tax year.
    /// </summary>
    [JsonPropertyName("social_security_tax_withheld")]
    public required string? SocialSecurityTaxWithheld { get; init; }

    /// <summary>
    /// Wages and tips from medicare.
    /// </summary>
    [JsonPropertyName("medicare_wages_and_tips")]
    public required string? MedicareWagesAndTips { get; init; }

    /// <summary>
    /// Medicare tax withheld for the tax year.
    /// </summary>
    [JsonPropertyName("medicare_tax_withheld")]
    public required string? MedicareTaxWithheld { get; init; }

    /// <summary>
    /// Tips from Social Security.
    /// </summary>
    [JsonPropertyName("social_security_tips")]
    public required string? SocialSecurityTips { get; init; }

    /// <summary>
    /// Allocated tips.
    /// </summary>
    [JsonPropertyName("allocated_tips")]
    public required string? AllocatedTips { get; init; }

    /// <summary>
    /// Contents from box 9 on the W2.
    /// </summary>
    [JsonPropertyName("box_9")]
    public required string? Box9 { get; init; }

    /// <summary>
    /// Dependent care benefits.
    /// </summary>
    [JsonPropertyName("dependent_care_benefits")]
    public required string? DependentCareBenefits { get; init; }

    /// <summary>
    /// Nonqualified plans.
    /// </summary>
    [JsonPropertyName("nonqualified_plans")]
    public required string? NonqualifiedPlans { get; init; }

    [JsonPropertyName("box_12")]
    public required IReadOnlyList<W2Box12> Box12 { get; init; }

    /// <summary>
    /// Statutory employee.
    /// </summary>
    [JsonPropertyName("statutory_employee")]
    public required string? StatutoryEmployee { get; init; }

    /// <summary>
    /// Retirement plan.
    /// </summary>
    [JsonPropertyName("retirement_plan")]
    public required string? RetirementPlan { get; init; }

    /// <summary>
    /// Third party sick pay.
    /// </summary>
    [JsonPropertyName("third_party_sick_pay")]
    public required string? ThirdPartySickPay { get; init; }

    /// <summary>
    /// Other.
    /// </summary>
    [JsonPropertyName("other")]
    public required string? Other { get; init; }

    [JsonPropertyName("state_and_local_wages")]
    public required IReadOnlyList<W2StateAndLocalWages> StateAndLocalWages { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
