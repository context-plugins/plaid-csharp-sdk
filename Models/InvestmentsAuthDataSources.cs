using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Object with metadata pertaining to the source of data for the account numbers, owners, and holdings that are returned.
/// </summary>
public record InvestmentsAuthDataSources
{
    /// <summary>
    /// A description of the source of data for a given product/data type.
    /// <para>
    /// <c>INSTITUTION</c>: The institution supports this product, and the data was provided by the institution.
    /// <c>INSTITUTION_MASK</c>: The user manually provided the full account number, which was matched to the account mask provided by the institution. Only applicable to the <c>numbers</c> data type.
    /// <c>USER</c>: The institution does not support this product, and the data was manually provided by the user.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("numbers")]
    public DataSources? Numbers { get; init; }

    /// <summary>
    /// A description of the source of data for a given product/data type.
    /// <para>
    /// <c>INSTITUTION</c>: The institution supports this product, and the data was provided by the institution.
    /// <c>INSTITUTION_MASK</c>: The user manually provided the full account number, which was matched to the account mask provided by the institution. Only applicable to the <c>numbers</c> data type.
    /// <c>USER</c>: The institution does not support this product, and the data was manually provided by the user.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("owners")]
    public DataSources? Owners { get; init; }

    /// <summary>
    /// A description of the source of data for a given product/data type.
    /// <para>
    /// <c>INSTITUTION</c>: The institution supports this product, and the data was provided by the institution.
    /// <c>INSTITUTION_MASK</c>: The user manually provided the full account number, which was matched to the account mask provided by the institution. Only applicable to the <c>numbers</c> data type.
    /// <c>USER</c>: The institution does not support this product, and the data was manually provided by the user.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("holdings")]
    public DataSources? Holdings { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
