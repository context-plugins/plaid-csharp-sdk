using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// The communication method containing both the type and address to send the URL.
/// </summary>
public record LinkDeliveryCommunicationMethod
{
    /// <summary>
    /// The delivery method to be used to deliver the Hosted Link session URL.
    /// <para>
    /// <c>SMS</c>: The URL will be delivered through SMS
    /// </para>
    /// <para>
    /// <c>EMAIL</c>: The URL will be delivered through email
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("method")]
    public LinkDeliveryDeliveryMethod? Method { get; init; }

    /// <summary>
    /// The phone number / email address that Hosted Link sessions are delivered to. Phone numbers must be in E.164 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    public string? Address { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
