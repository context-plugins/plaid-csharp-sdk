using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An optional set of options to be used when configuring the Item. If specified, must not be <c>null</c>.
/// </summary>
public record SandboxProcessorTokenCreateRequestOptions
{
    /// <summary>
    /// Test username to use for the creation of the Sandbox Item. Default value is <c>user_good</c>. You can also use a custom test user — either set this to the username of a custom user configured in the Dashboard, or set it to <c>user_custom</c> and pass the JSON-stringified custom user configuration object as <c>override_password</c> to define one entirely via API. See <see href="https://plaid.com/docs/sandbox/user-custom">Sandbox Custom Users</see> for more details.
    /// </summary>
    [JsonPropertyName("override_username")]
    public string? OverrideUsername { get; init; } = "user_good";

    /// <summary>
    /// Test password to use for the creation of the Sandbox Item. Default value is <c>pass_good</c>. You can also use a custom test user — reference one configured in the Dashboard via <c>override_username</c>, or set <c>override_username</c> to <c>user_custom</c> and pass the JSON-stringified custom user configuration object as this field to define one entirely via API. See <see href="https://plaid.com/docs/sandbox/user-custom">Sandbox Custom Users</see> for more details.
    /// </summary>
    [JsonPropertyName("override_password")]
    public string? OverridePassword { get; init; } = "pass_good";

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
