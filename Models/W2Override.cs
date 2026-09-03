using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// W2 is an object that represents income data taken from a W2 tax document.
/// </summary>
public record W2Override
{
    /// <summary>
    /// The employer on the paystub.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("employer")]
    public PaystubOverrideEmployer? Employer { get; init; }

    /// <summary>
    /// The employee on the paystub.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("employee")]
    public PaystubOverrideEmployee? Employee { get; init; }

    /// <summary>
    /// The tax year of the W2 document.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tax_year")]
    public string? TaxYear { get; init; }

    /// <summary>
    /// An employer identification number or EIN.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("employer_id_number")]
    public string? EmployerIdNumber { get; init; }

    /// <summary>
    /// Wages from tips and other compensation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wages_tips_other_comp")]
    public string? WagesTipsOtherComp { get; init; }

    /// <summary>
    /// Federal income tax withheld for the tax year.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("federal_income_tax_withheld")]
    public string? FederalIncomeTaxWithheld { get; init; }

    /// <summary>
    /// Wages from Social Security.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("social_security_wages")]
    public string? SocialSecurityWages { get; init; }

    /// <summary>
    /// Social Security tax withheld for the tax year.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("social_security_tax_withheld")]
    public string? SocialSecurityTaxWithheld { get; init; }

    /// <summary>
    /// Wages and tips from medicare.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("medicare_wages_and_tips")]
    public string? MedicareWagesAndTips { get; init; }

    /// <summary>
    /// Medicare tax withheld for the tax year.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("medicare_tax_withheld")]
    public string? MedicareTaxWithheld { get; init; }

    /// <summary>
    /// Tips from Social Security.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("social_security_tips")]
    public string? SocialSecurityTips { get; init; }

    /// <summary>
    /// Allocated tips.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allocated_tips")]
    public string? AllocatedTips { get; init; }

    /// <summary>
    /// Contents from box 9 on the W2.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("box_9")]
    public string? Box9 { get; init; }

    /// <summary>
    /// Dependent care benefits.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dependent_care_benefits")]
    public string? DependentCareBenefits { get; init; }

    /// <summary>
    /// Nonqualified plans.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nonqualified_plans")]
    public string? NonqualifiedPlans { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("box_12")]
    public IReadOnlyList<W2Box12Override>? Box12 { get; init; }

    /// <summary>
    /// Statutory employee.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("statutory_employee")]
    public string? StatutoryEmployee { get; init; }

    /// <summary>
    /// Retirement plan.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("retirement_plan")]
    public string? RetirementPlan { get; init; }

    /// <summary>
    /// Third party sick pay.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("third_party_sick_pay")]
    public string? ThirdPartySickPay { get; init; }

    /// <summary>
    /// Other.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("other")]
    public string? Other { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("state_and_local_wages")]
    public IReadOnlyList<W2StateAndLocalWagesOverride>? StateAndLocalWages { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
