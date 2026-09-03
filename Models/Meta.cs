using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Allows specifying the metadata of the test account
/// </summary>
public record Meta
{
    /// <summary>
    /// The account's name
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The account's official name
    /// </summary>
    [JsonPropertyName("official_name")]
    public required string OfficialName { get; init; }

    /// <summary>
    /// The account's limit
    /// </summary>
    [JsonPropertyName("limit")]
    public required double Limit { get; init; }

    /// <summary>
    /// The account's mask. Should be an empty string or a string of 2-4 alphanumeric characters. This allows you to model a mask which does not match the account number (such as with a virtual account number).
    /// </summary>
    [JsonPropertyName("mask")]
    [RegularExpression("^$|^[A-Za-z0-9]{2,4}$")]
    public required string Mask { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
