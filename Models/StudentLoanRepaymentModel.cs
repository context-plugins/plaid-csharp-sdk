using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Student loan repayment information used to configure Sandbox test data for the Liabilities product
/// </summary>
public record StudentLoanRepaymentModel
{
    /// <summary>
    /// The only currently supported value for this field is <c>standard</c>.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    /// <summary>
    /// Configures the number of months before repayment starts.
    /// </summary>
    [JsonPropertyName("non_repayment_months")]
    public required double NonRepaymentMonths { get; init; }

    /// <summary>
    /// Configures the number of months of repayments before the loan is paid off.
    /// </summary>
    [JsonPropertyName("repayment_months")]
    public required double RepaymentMonths { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
