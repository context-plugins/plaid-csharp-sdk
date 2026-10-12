using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Request input for creating a Beacon User.
/// <para>
/// The primary use for this endpoint is to add a new end user to Beacon for fraud and duplicate scanning.
/// </para>
/// <para>
/// Some fields are optional, but it is recommended to provide as much information as possible to improve
/// the accuracy of the fraud and duplicate scanning.
/// </para>
/// </summary>
public record BeaconUserCreateRequest
{
    /// <summary>
    /// ID of the associated Beacon Program.
    /// </summary>
    [JsonPropertyName("program_id")]
    public required string ProgramId { get; init; }

    /// <summary>
    /// A unique ID that identifies the end user in your system. Either a <c>user_id</c> or the <c>client_user_id</c> must be provided. This ID can also be used to associate user-specific data from other Plaid products. Financial Account Matching requires this field and the <c>/link/token/create</c> <c>client_user_id</c> to be consistent. Personally identifiable information, such as an email address or phone number, should not be used in the <c>client_user_id</c>.
    /// </summary>
    [JsonPropertyName("client_user_id")]
    public required string ClientUserId { get; init; }

    /// <summary>
    /// A Beacon User's data which is used to check against duplicate records and the Beacon Fraud Network.
    /// <para>
    /// In order to create a Beacon User, in addition to the <c>name</c>, _either_ the <c>date_of_birth</c> _or_ the <c>depository_accounts</c> field must be provided.
    /// </para>
    /// </summary>
    [JsonPropertyName("user")]
    public required BeaconUserRequestData User { get; init; }

    /// <summary>
    /// Send this array of access tokens to link accounts to the Beacon User and have them evaluated for Account Insights.
    /// A maximum of 50 accounts total can be added to a single Beacon User.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("access_tokens")]
    public IReadOnlyList<string>? AccessTokens { get; init; }

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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
