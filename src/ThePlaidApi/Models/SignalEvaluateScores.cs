using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Risk scoring details broken down by risk category. When using a Balance-only ruleset, this object will not be returned.
/// </summary>
public record SignalEvaluateScores
{
    /// <summary>
    /// The object contains a risk score and a risk tier that evaluate the transaction return risk of an unauthorized debit. Common return codes in this category include: "R05", "R07", "R10", "R11", "R29". These returns typically have a return time frame of up to 60 calendar days. During this period, customers of financial institutions can dispute a transaction as unauthorized.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer_initiated_return_risk")]
    public CustomerInitiatedReturnRisk? CustomerInitiatedReturnRisk { get; init; }

    /// <summary>
    /// The object contains a risk score and a risk tier that evaluate the transaction return risk because an account is overdrawn or because an ineligible account is used. Common return codes in this category include: "R01", "R02", "R03", "R04", "R06", "R08", "R09", "R13", "R16", "R17", "R20", "R23". These returns have a turnaround time of 2 banking days.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bank_initiated_return_risk")]
    public BankInitiatedReturnRisk? BankInitiatedReturnRisk { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
