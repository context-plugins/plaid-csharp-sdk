using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object representing an end user's Form I-20 US immigration student document.
/// </summary>
public record CreditI20
{
    /// <summary>
    /// An identifier of the document referenced by the document metadata.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("document_id")]
    public string? DocumentId { get; init; }

    /// <summary>
    /// Object representing metadata pertaining to the document.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("document_metadata")]
    public CreditDocumentMetadata? DocumentMetadata { get; init; }

    /// <summary>
    /// An object representing the student named on a Form I-20.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("student")]
    public CreditI20Student? Student { get; init; }

    /// <summary>
    /// Amount of the student's personal funds.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("personal_funds")]
    public double? PersonalFunds { get; init; }

    /// <summary>
    /// Amount of funds from on-campus employment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("on_campus_employment")]
    public double? OnCampusEmployment { get; init; }

    /// <summary>
    /// Amount of funds provided by the issuing school.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("funds_from_this_school")]
    public double? FundsFromThisSchool { get; init; }

    /// <summary>
    /// Total amount of funds available to the student.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("students_funding_total")]
    public double? StudentsFundingTotal { get; init; }

    /// <summary>
    /// Amount of funds from another source.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("funds_from_another_source")]
    public double? FundsFromAnotherSource { get; init; }

    /// <summary>
    /// Estimated total average costs for the program period.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("estimated_average_costs_total")]
    public double? EstimatedAverageCostsTotal { get; init; }

    /// <summary>
    /// Estimated average living expenses.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("estimated_average_living_expenses")]
    public double? EstimatedAverageLivingExpenses { get; init; }

    /// <summary>
    /// Number of months the student's funding covers.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("students_funding_period_months")]
    public long? StudentsFundingPeriodMonths { get; init; }

    /// <summary>
    /// Number of months the estimated average costs cover.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("estimated_average_costs_period_months")]
    public long? EstimatedAverageCostsPeriodMonths { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
