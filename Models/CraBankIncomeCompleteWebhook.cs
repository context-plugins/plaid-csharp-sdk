using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Fired when a bank income report has finished generating or failed to generate, triggered by calling <c>/credit/bank_income/get</c>.
/// </summary>
public record CraBankIncomeCompleteWebhook
{
    /// <summary>
    /// <c>CRA_INCOME</c>
    /// </summary>
    [JsonPropertyName("webhook_type")]
    public required string WebhookType { get; init; }

    /// <summary>
    /// <c>BANK_INCOME_COMPLETE</c>
    /// </summary>
    [JsonPropertyName("webhook_code")]
    public required string WebhookCode { get; init; }

    /// <summary>
    /// The <c>user_id</c> corresponding to the user the webhook has fired for.
    /// </summary>
    [JsonPropertyName("user_id")]
    public required string UserId { get; init; }

    /// <summary>
    /// The result of the bank income report generation
    /// <para>
    /// <c>SUCCESS</c>: The bank income report was successfully generated and can be retrieved via <c>/credit/bank_income/get</c>.
    /// </para>
    /// <para>
    /// <c>FAILURE</c>: The bank income report failed to be generated
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("result")]
    public CraBankIncomeCompleteResult? Result { get; init; }

    /// <summary>
    /// The Plaid environment the webhook was sent from
    /// </summary>
    [JsonPropertyName("environment")]
    public required WebhookEnvironmentValues Environment { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
