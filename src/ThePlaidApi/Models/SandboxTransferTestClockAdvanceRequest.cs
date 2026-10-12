using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Defines the request schema for <c>/sandbox/transfer/test_clock/advance</c>
/// </summary>
public record SandboxTransferTestClockAdvanceRequest
{
    /// <summary>
    /// Your Plaid API <c>client_id</c>. The <c>client_id</c> is required and may be provided either in the <c>PLAID-CLIENT-ID</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_id")]
    public string? ClientId { get; init; }

    /// <summary>
    /// Your Plaid API <c>secret</c>. The <c>secret</c> is required and may be provided either in the <c>PLAID-SECRET</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secret")]
    public string? Secret { get; init; }

    /// <summary>
    /// Plaid's unique identifier for a test clock. This field is only populated in the Sandbox environment, and only if a <c>test_clock_id</c> was included in the <c>/transfer/recurring/create</c> request. For more details, see <see href="https://plaid.com/docs/transfer/sandbox/#simulating-recurring-transfers">Simulating recurring transfers</see>.
    /// </summary>
    [JsonPropertyName("test_clock_id")]
    public required string TestClockId { get; init; }

    /// <summary>
    /// The virtual timestamp on the test clock. This will be of the form <c>2006-01-02T15:04:05Z</c>.
    /// </summary>
    [JsonPropertyName("new_virtual_time")]
    public required DateTimeOffset NewVirtualTime { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
