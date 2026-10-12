using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// SessionTokenCreateRequest defines the request schema for <c>/session/token/create</c>
/// </summary>
public record SessionTokenCreateRequest
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
    /// The id of a template defined in Plaid Dashboard
    /// </summary>
    [JsonPropertyName("template_id")]
    public required string TemplateId { get; init; }

    /// <summary>
    /// Details about the end user. Required if a root-level <c>user_id</c> is not provided.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user")]
    public SessionTokenCreateRequestUser? User { get; init; }

    /// <summary>
    /// A URI indicating the destination where a user should be forwarded after completing the Link flow; used to support OAuth authentication flows when launching Link in the browser or another app. The <c>redirect_uri</c> should not contain any query parameters. When used in Production, must be an https URI. Note that any redirect URI must also be added to the Allowed redirect URIs list in the <see href="https://dashboard.plaid.com/team/api">developer dashboard</see>. If initializing on Android, <c>android_package_name</c> must be specified instead and <c>redirect_uri</c> should be left blank.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("redirect_uri")]
    public string? RedirectUri { get; init; }

    /// <summary>
    /// The name of your app's Android package. Required if using the session token to initialize Layer on Android. Any package name specified here must also be added to the Allowed Android package names setting on the <see href="https://dashboard.plaid.com/team/api">developer dashboard</see>. When creating a session token for initializing Layer on other platforms, <c>android_package_name</c> must be left blank and <c>redirect_uri</c> should be used instead.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("android_package_name")]
    public string? AndroidPackageName { get; init; }

    /// <summary>
    /// The destination URL to which any webhooks should be sent. If you use the same webhook listener for all Sandbox or all Production activity, set this value in the Layer template editor in the Dashboard instead. Only provide a value in this field if you need to use multiple webhook URLs per environment (an uncommon use case). If provided, a value in this field will take priority over webhook values set in the Layer template editor.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("webhook")]
    public string? Webhook { get; init; }

    /// <summary>
    /// A unique user identifier, created by <c>/user/create</c>. Integrations that began using <c>/user/create</c> after December 10, 2025 use this field to identify a user instead of the <c>user_token</c>. For more details, see <see href="https://plaid.com/docs/api/users/user-apis">New User APIs</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user_id")]
    public string? UserId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
