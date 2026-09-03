using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// The details for the newly created end customer, including secrets for non-Production environments.
/// </summary>
public record PartnerEndCustomerWithSecrets
{
    /// <summary>
    /// The <c>client_id</c> of the end customer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_id")]
    public string? ClientId { get; init; }

    /// <summary>
    /// The company name associated with the end customer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("company_name")]
    public string? CompanyName { get; init; }

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
    /// The secrets for the newly created end customer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secrets")]
    public PartnerEndCustomerSecrets? Secrets { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
