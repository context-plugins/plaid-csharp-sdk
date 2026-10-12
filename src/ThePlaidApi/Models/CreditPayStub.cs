using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object representing an end user's pay stub.
/// </summary>
public record CreditPayStub
{
    /// <summary>
    /// An object with the deduction information found on a pay stub.
    /// </summary>
    [JsonPropertyName("deductions")]
    public required CreditPayStubDeductions Deductions { get; init; }

    /// <summary>
    /// An identifier of the document referenced by the document metadata.
    /// </summary>
    [JsonPropertyName("document_id")]
    public required string? DocumentId { get; init; }

    /// <summary>
    /// Object representing metadata pertaining to the document.
    /// </summary>
    [JsonPropertyName("document_metadata")]
    public required CreditDocumentMetadata DocumentMetadata { get; init; }

    /// <summary>
    /// An object representing both a breakdown of earnings on a pay stub and the total earnings.
    /// </summary>
    [JsonPropertyName("earnings")]
    public required CreditPayStubEarnings Earnings { get; init; }

    /// <summary>
    /// Data about the employee.
    /// </summary>
    [JsonPropertyName("employee")]
    public required CreditPayStubEmployee Employee { get; init; }

    /// <summary>
    /// Information about the employer on the pay stub.
    /// </summary>
    [JsonPropertyName("employer")]
    public required CreditPayStubEmployer Employer { get; init; }

    /// <summary>
    /// An object representing information about the net pay amount on the pay stub.
    /// </summary>
    [JsonPropertyName("net_pay")]
    public required CreditPayStubNetPay NetPay { get; init; }

    /// <summary>
    /// Details about the pay period.
    /// </summary>
    [JsonPropertyName("pay_period_details")]
    public required PayStubPayPeriodDetails PayPeriodDetails { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
