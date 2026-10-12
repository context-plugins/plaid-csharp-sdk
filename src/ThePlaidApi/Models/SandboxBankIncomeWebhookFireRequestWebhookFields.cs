using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Optional fields which will be populated in the simulated webhook
/// </summary>
public record SandboxBankIncomeWebhookFireRequestWebhookFields
{
    /// <summary>
    /// The user id to be returned in INCOME webhooks
    /// </summary>
    [JsonPropertyName("user_id")]
    public required string UserId { get; init; }

    /// <summary>
    /// The result of the bank income refresh report generation
    /// <para>
    /// <c>SUCCESS</c>: The refreshed report was successfully generated and can be retrieved via <c>/credit/bank_income/get</c>.
    /// </para>
    /// <para>
    /// <c>FAILURE</c>: The refreshed report failed to be generated
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bank_income_refresh_complete_result")]
    public BankIncomeRefreshCompleteResult? BankIncomeRefreshCompleteResult { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
