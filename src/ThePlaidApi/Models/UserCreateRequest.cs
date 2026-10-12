using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// UserCreateRequest defines the request schema for <c>/user/create</c>
/// </summary>
public record UserCreateRequest
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
    /// A unique ID representing the end user. Maximum of 128 characters. Typically this will be a user ID number from your application. Personally identifiable information, such as an email address or phone number, should not be used in the <c>client_user_id</c>.
    /// </summary>
    [JsonPropertyName("client_user_id")]
    [StringLength(128, MinimumLength = 1)]
    public required string ClientUserId { get; init; }

    /// <summary>
    /// The identity fields associated with a user. For a user to be eligible for a Plaid Check Consumer Report, all fields are required except <c>id_number</c>. Providing a partial SSN is strongly recommended, and improves the accuracy of matching user records during compliance processes such as file disclosure, dispute, or security freeze requests. If creating a report that will be shared with GSEs such as Fannie or Freddie, a full Social Security Number must be provided via the <c>id_number</c> field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("identity")]
    public ClientUserIdentity? Identity { get; init; }

    /// <summary>
    /// A unique ID representing a CRA reseller's end customer. Maximum of 128 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("end_customer")]
    [StringLength(128, MinimumLength = 0)]
    public string? EndCustomer { get; init; }

    /// <summary>
    /// This field is only used by integrations created before December 10, 2025. All other integrations must use the <c>identity</c> object instead. For more details, see <see href="https://plaid.com/docs/api/users/user-apis">New User APIs</see>.
    /// To create a Plaid Check Consumer Report for a user when using a <c>user_token</c>, this field must be present. If this field is not provided during user token creation, you can add it to the user later by calling <c>/user/update</c>. Once the field has been added to the user, you will be able to call <c>/link/token/create</c> with a non-empty <c>consumer_report_permissible_purpose</c> (which will automatically create a Plaid Check Consumer Report), or call <c>/cra/check_report/create</c> for that user.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("consumer_report_user_identity")]
    public ConsumerReportUserIdentity? ConsumerReportUserIdentity { get; init; }

    /// <summary>
    /// If your integration with the User API predates December 10, 2025, set this field to <c>true</c> to opt into the <see href="https://plaid.com/docs/api/users/user-apis/">New User APIs</see>. When enabled, you can use the <c>identity</c> field instead of <c>consumer_report_user_identity</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("with_upgraded_user")]
    public bool? WithUpgradedUser { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
