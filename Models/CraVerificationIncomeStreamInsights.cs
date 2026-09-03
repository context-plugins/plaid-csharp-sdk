using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Modeled insights for a given income stream.
/// </summary>
public record CraVerificationIncomeStreamInsights
{
    /// <summary>
    /// The income category for a given stream. The streams returned in the response will be filtered based on these primary and secondary income categories.
    /// <para>
    /// See the <see href="https://plaid.com/documents/income-v2-category-taxonomy.csv">Income V2 Category Taxonomy</see> for a full list of income categories.
    /// </para>
    /// </summary>
    [JsonPropertyName("income_category")]
    public required CraVerificationIncomeCategory IncomeCategory { get; init; }

    /// <summary>
    /// The income pay frequency.
    /// <c>WEEKLY</c>: Weekly pay frequency.
    /// <c>BIWEEKLY</c>: Biweekly pay frequency.
    /// <c>SEMI_MONTHLY</c>: Semi-monthly pay frequency.
    /// <c>MONTHLY</c>: Monthly pay frequency.
    /// <c>DAILY</c>: Daily pay frequency.
    /// <c>UNKNOWN</c>: Pay frequency is unknown.
    /// </summary>
    [JsonPropertyName("pay_frequency")]
    public required CraVerificationIncomePayFrequency PayFrequency { get; init; }

    /// <summary>
    /// The object containing data about the income provider.
    /// </summary>
    [JsonPropertyName("income_provider")]
    public required CraVerificationIncomeProvider? IncomeProvider { get; init; }

    /// <summary>
    /// The status of the income source.
    /// <c>ACTIVE</c>: The income source is active.
    /// <c>INACTIVE</c>: The income source is inactive.
    /// <c>UNKNOWN</c>: The income source status is unknown.
    /// </summary>
    [JsonPropertyName("status")]
    public required CraVerificationIncomeStatus Status { get; init; }

    /// <summary>
    /// Metadata of the income stream's next payment.
    /// </summary>
    [JsonPropertyName("next_payment")]
    public required CraVerificationIncomeNextPayment? NextPayment { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
