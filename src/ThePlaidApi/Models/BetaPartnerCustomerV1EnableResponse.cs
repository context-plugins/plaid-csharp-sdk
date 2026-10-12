using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Response schema for <c>/beta/partner/customer/v1/enable</c>.
/// </summary>
public record BetaPartnerCustomerV1EnableResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("end_customer_client_id")]
    public string? EndCustomerClientId { get; init; }

    /// <summary>
    /// The status of the given end customer.
    /// <para>
    /// <c>UNDER_REVIEW</c>: The end customer has been created and enabled in the Sandbox environment. The end customer must be manually reviewed by the Plaid team before it can be enabled in Production, at which point its status will automatically transition to <c>PENDING_ENABLEMENT</c> or <c>DENIED</c>.
    /// </para>
    /// <para>
    /// <c>PENDING_ENABLEMENT</c>: The end customer is ready to be fully enabled in the Production environment. Call the <c>/partner/customer/enable</c> endpoint to enable the end customer in full Production.
    /// </para>
    /// <para>
    /// <c>ACTIVE</c>: The end customer has been fully enabled in all environments.
    /// </para>
    /// <para>
    /// <c>DENIED</c>: The end customer has been created and enabled in the Sandbox environment, but it did not pass review by the Plaid team and therefore cannot be enabled for Production access. Talk to your account manager for more information.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public PartnerEndCustomerStatus? Status { get; init; }

    /// <summary>
    /// Mapping of product names to their current status.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("product_statuses")]
    public object? ProductStatuses { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("production_secret")]
    public string? ProductionSecret { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("request_id")]
    public string? RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
