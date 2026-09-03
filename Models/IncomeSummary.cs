using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The verified fields from a paystub verification. All fields are provided as reported on the paystub.
/// </summary>
public record IncomeSummary
{
    /// <summary>
    /// The name of the employer, as reported on the paystub.
    /// </summary>
    [JsonPropertyName("employer_name")]
    public required EmployerIncomeSummaryFieldString? EmployerName { get; init; }

    /// <summary>
    /// The name of the employee, as reported on the paystub.
    /// </summary>
    [JsonPropertyName("employee_name")]
    public required EmployeeIncomeSummaryFieldString? EmployeeName { get; init; }

    /// <summary>
    /// Year-to-date pre-tax earnings, as reported on the paystub.
    /// </summary>
    [JsonPropertyName("ytd_gross_income")]
    public required YtdGrossIncomeSummaryFieldNumber? YtdGrossIncome { get; init; }

    /// <summary>
    /// Year-to-date earnings after any tax withholdings, benefit payments or deductions, as reported on the paystub.
    /// </summary>
    [JsonPropertyName("ytd_net_income")]
    public required YtdNetIncomeSummaryFieldNumber? YtdNetIncome { get; init; }

    /// <summary>
    /// The frequency of the pay period.
    /// </summary>
    [JsonPropertyName("pay_frequency")]
    public required PayFrequency? PayFrequency { get; init; }

    /// <summary>
    /// The employee's estimated annual salary, as derived from information reported on the paystub.
    /// </summary>
    [JsonPropertyName("projected_wage")]
    public required ProjectedIncomeSummaryFieldNumber? ProjectedWage { get; init; }

    /// <summary>
    /// Information about the matched direct deposit transaction used to verify a user's payroll information.
    /// </summary>
    [JsonPropertyName("verified_transaction")]
    public required TransactionData? VerifiedTransaction { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
