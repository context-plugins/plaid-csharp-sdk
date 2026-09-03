using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Defines the test clock for a transfer.
/// </summary>
public record TransferTestClock
{
    /// <summary>
    /// Plaid's unique identifier for a test clock. This field is only populated in the Sandbox environment, and only if a <c>test_clock_id</c> was included in the <c>/transfer/recurring/create</c> request. For more details, see <see href="https://plaid.com/docs/transfer/sandbox/#simulating-recurring-transfers">Simulating recurring transfers</see>.
    /// </summary>
    [JsonPropertyName("test_clock_id")]
    public required string TestClockId { get; init; }

    /// <summary>
    /// The virtual timestamp on the test clock. This will be of the form <c>2006-01-02T15:04:05Z</c>.
    /// </summary>
    [JsonPropertyName("virtual_time")]
    public required DateTimeOffset VirtualTime { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
